﻿using System;
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
            SqlConnection conn = new SqlConnection("Write your connection string here");
            return conn;
        }
        
    }
}
