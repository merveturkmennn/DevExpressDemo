using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataGrid01
{
    internal class ReplaceValueMethod
    {
        static public string ReplaceValue(object value)
        {
            if (value == null) value = string.Empty;
            if (!(value is string)) return Convert.ToString(value).Replace(",", ".");
            return (value as string).Replace("'", "''");
        }
    }
}
