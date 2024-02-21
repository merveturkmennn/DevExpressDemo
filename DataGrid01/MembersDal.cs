using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace DataGrid01
{
    internal class MembersDal
    {

        public List< Member> GetAll()
        {
            SqlConnection connection = new SqlConnection(@"data source=192.168.0.123;initial catalog=IDEASOFT;persist security info=True;
            user id=sa;password=Bb000000;MultipleActiveResultSets=True;Encrypt=False;");
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
            SqlCommand command = new SqlCommand("Select Top 10 Username from ProcessLogs group by Username", connection);
            SqlDataReader reader = command.ExecuteReader();
            List<Member> members = new List<Member>();
            while (reader.Read())
            {
                Member member = new Member()
                {
                    Username = reader["Username"].ToString()
                };
                members.Add(member);
            }
            reader.Close();
            connection.Close();
            return members;

        }
    }
}
