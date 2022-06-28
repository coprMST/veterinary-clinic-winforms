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
        internal class ConnectionSettings
        {
            /// <summary>
            /// Хранит название подключаемого клиента к базе данных.
            /// </summary>
            internal static string DataSource = Environment.MachineName;
            /// <summary>
            /// Хранит название базы данных при подключении.
            /// </summary>
            internal static string InitialCatalog = "VeterinaryClinicDB";
        }

        /// <summary>
        /// Возвращаемый набор данных.
        /// </summary>
        internal class MyResultData
        {
            /// <summary>
            /// Возвращает результат запроса.
            /// </summary>
            internal DataTable ResultData;
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
        internal static MyResultData SqlReturnDataTable(string cmd)
        {
            var result = new MyResultData();

            try
            {
                var con = new SqlConnection($@"Data Source = {ConnectionSettings.DataSource};Initial catalog={ConnectionSettings.InitialCatalog};Integrated security=True");
                var command = new SqlCommand(cmd, con);

                con.Open();
                var adapter = new SqlDataAdapter();
                adapter.SelectCommand = command;
                var dataSet = new DataSet();
                adapter.Fill(dataSet);
                result.ResultData = dataSet.Tables[0];
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
