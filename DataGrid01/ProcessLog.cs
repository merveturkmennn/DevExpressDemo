using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid01
{
    internal class ProcessLog
    {

        public int Id { get; set; }
        public int IdeaSoftId { get; set; }
        public int UserId { get; set; }
        public string Username { get; set; }
        public string Ip { get; set; }
        public DateTime CreatedAt { get; set; }
        public int RecordId { get; set; }
        public string Module { get; set; }
        public string File { get; set; }
        public string Act { get; set; }
        public string UserType { get; set; }
        public string TableName { get; set; }
        public string FunctionName { get; set; }
        public string ModuleNameVerbose { get; set; }
        public string LogSentence { get; set; }






    }
}
