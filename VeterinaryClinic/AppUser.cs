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
        internal static string EmployeeId { get; set; }
        internal static string CustomerId { get; set; }
        internal static string UserName { get; set; }

        internal static void AutoAuthUser()
        {
            var login = Empty;
            var password = Empty;
            var result = new Data.MyResultData();

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
                    return;
                }

                return;
            }

            if (Regex.IsMatch(login, ".+[@].+[.].+"))
            {
                result = Data.SqlReturnDataTable($@"execute [dbo].[Auth] null, '{login}', '{password}'");
            }
            else if (long.TryParse(login, out _))
            {
                result = Data.SqlReturnDataTable($@"execute [dbo].[Auth] '{login}', null, '{password}'");
            }

            if (result.HasError || result.HasZeroRows)
            {
                File.Delete(@"temp");
                return;
            }

            switch (result.ResultData.Rows[0][5].ToString())
            {
                case "1": CustomerId = result.ResultData.Rows[0][5].ToString(); break;
                case "2": EmployeeId = result.ResultData.Rows[0][5].ToString(); break;
            }

            AccountId = result.ResultData.Rows[0][0].ToString();
            UserName = result.ResultData.Rows[0][2] + " " + result.ResultData.Rows[0][3].ToString().Substring(0, 1) + ".";
            if (result.ResultData.Rows[0][4] != DBNull.Value)
                UserName += result.ResultData.Rows[0][4].ToString().Substring(0, 1) + ".";

            Program.MainFormLink.goToAuth.Visible = false;
            Program.MainFormLink.goToReg.Visible = false;
            Program.MainFormLink.goToLogOut.Visible = true;
            Program.MainFormLink.myNameLabel.Text = UserName;
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
