using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DataGrid01.ReplaceValueMethod;
namespace DataGrid01
{
    internal class ProcessLogDal
    {
        public List<ProcessLog> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"data source=192.168.0.123;initial catalog=IDEASOFT;persist security info=True;
            user id=sa;password=Bb000000;MultipleActiveResultSets=True;Encrypt=False;");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select Top 10000 * from ProcessLogs Order By  IdeaSoftId desc", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<ProcessLog> processLogs = new List<ProcessLog>();
            while (reader.Read())
            {
                ProcessLog processLog = new ProcessLog
                {
                    Id= Convert.ToInt32(reader["Id"]),
                    IdeaSoftId = Convert.ToInt32(reader["IdeaSoftId"]),
                    UserId = Convert.ToInt32(reader["UserId"]),
                    Username = reader["Username"].ToString(),
                    Ip = reader["Ip"].ToString(),
                    CreatedAt = Convert.ToDateTime(reader["CreatedAt"]),
                    RecordId = Convert.ToInt32(reader["RecordId"]),
                    Module = reader["Module"].ToString(),
                    File = ReplaceValue(reader["File"]),
                    Act = reader["Act"].ToString(),
                    UserType = reader["UserType"].ToString(),
                    TableName = reader["TableName"].ToString(),
                    FunctionName = reader["FunctionName"].ToString(),
                    ModuleNameVerbose = reader["ModuleNameVerbose"].ToString(),
                    LogSentence = reader["LogSentence"].ToString(),

                };
                processLogs.Add(processLog);
            }

            reader.Close();
            connection.Close();
            return processLogs;

        }
    }
}
