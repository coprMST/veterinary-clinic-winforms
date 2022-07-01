using System;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using static System.String;

namespace VeterinaryClinic
{
    internal class AppUser
    {
        internal static string AccountId { get; set; }
        internal static string AccountType { get; set; }
        internal static string FirstName { get; set; }
        internal static string LastName { get; set; }
        internal static string MiddleName { get; set; }
        internal static int AmountRecordsInPage = 10;

        internal static string GetName()
        {
            var userName = FirstName + " " + LastName.Substring(0, 1) + ".";
            if (!IsNullOrEmpty(MiddleName))
                userName += MiddleName.Substring(0, 1) + ".";
            return userName;
        }

        internal static bool AutoAuthUser()
        {
            var login = Empty;
            var password = Empty;
            var result = new Data.Result();

            try
            {
                using (var sr = new StreamReader("temp", Encoding.Default))
                {
                    string line;
                    while ((line = sr.ReadLine()) != null)
                    {
                        login = line.Split(' ')[0];
                        password = line.Split(' ')[1];
                    }
                }
            }
            catch
            {
                try
                {
                    File.Delete(@"temp");
                }
                catch
                {
                    return false;
                }

                return false;
            }

            if (Regex.IsMatch(login, ".+[@].+[.].+"))
            {
                result = Data.ReturnDataTable($@"execute [dbo].[Auth] null, '{login}', '{password}'");
            }
            else if (long.TryParse(login, out _))
            {
                result = Data.ReturnDataTable($@"execute [dbo].[Auth] '{login}', null, '{password}'");
            }

            if (result.HasError || result.HasZeroRows)
            {
                File.Delete(@"temp");
                return false;
            }

            AccountType = result.DataTable.Rows[0][5].ToString();
            AccountId = result.DataTable.Rows[0][0].ToString();
            FirstName = result.DataTable.Rows[0][2].ToString();
            LastName = result.DataTable.Rows[0][3].ToString();
            if (result.DataTable.Rows[0][4] != DBNull.Value)
                MiddleName = result.DataTable.Rows[0][4].ToString();

            return true;
        }
        
        internal static void CreateUserFile(string login, string password)
        {
            const string path = "temp";
            var fs = File.Open(path, File.Exists(path) ? FileMode.Truncate : FileMode.OpenOrCreate);
            File.SetAttributes(path, FileAttributes.Hidden | FileAttributes.Compressed);
            using (var sw = new StreamWriter(fs, Encoding.Default))
                sw.WriteLine("{0} {1}", login, password);
            fs.Close();
        }

        internal static void DeleteUserFile()
        {
            if (File.Exists("temp"))
                File.Delete("temp");
        }
    }
}
