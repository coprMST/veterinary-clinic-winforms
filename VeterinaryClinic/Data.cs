using System;
using System.Data.SqlClient;
using System.Data;

namespace VeterinaryClinic
{
    /// <summary>
    /// Набор компонентов для простой работы с Microsoft SQL Server.
    /// </summary>
    internal static class Data
    {
        /// <summary>
        /// Набор данных для подключения к базе данных
        /// </summary>
        internal class Settings
        {
            /// <summary>
            /// Возращает или присваивает имя сервера.
            /// </summary>
            internal static string DataSource = Environment.MachineName;
            /// <summary>
            /// Возращает или присваивает имя базы данных.
            /// </summary>
            internal static string InitialCatalog = "VeterinaryClinicDB";
        }

        /// <summary>
        /// Возвращаемый набор данных.
        /// </summary>
        internal class Result
        {
            /// <summary>
            /// Возвращает результат запроса.
            /// </summary>
            internal DataTable DataTable;
            /// <summary>
            /// Возвращает текст ошибки.
            /// </summary>
            internal string ErrorText;
            /// <summary>
            /// Возвращает True - если произошла ошибка.
            /// </summary>
            internal bool HasError;
            /// <summary>
            /// Возвращает True - если количество строк равно нулю.
            /// </summary>
            internal bool HasZeroRows;
        }

        /// <summary>
        /// Выполняет запрос выборки набора строк.
        /// </summary>
        /// <param name="cmd">Запрос к базе данных</param>
        /// <returns>Возвращает набор строк в DataTable.</returns>
        internal static Result ReturnDataTable(string cmd)
        {
            var result = new Result();

            try
            {
                var con = new SqlConnection($@"Data Source = {Settings.DataSource};Initial catalog={Settings.InitialCatalog};Integrated security=True");
                var command = new SqlCommand(cmd, con);

                con.Open();
                var adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                result.DataTable = dataSet.Tables[0];
                con.Close();

                if (dataSet.Tables[0].Rows.Count == 0)
                {
                    result.HasZeroRows = true;
                    return result;
                }
            }
            catch (Exception ex)
            {
                result.HasError = true;
                result.ErrorText = ex.Message;
            }

            return result;
        }
    }
}
