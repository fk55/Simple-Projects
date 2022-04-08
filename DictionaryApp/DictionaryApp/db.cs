using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DictionaryApp
{
    public static class db
    {
        public static SqlConnection conn()
        {
            SqlConnection conn = new SqlConnection(@"Server=DESKTOP-MO5HLC4\SQLEXPRESS; Database=fk; Trusted_Connection=True;" + "Integrated Security=true;");
            return conn;
        }
        
    }
}
