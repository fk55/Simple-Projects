using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DictionaryApp
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);


           

            Application.Run(new Form1(GetDictionary()));
        }

        public static SortedDictionary<string, string> GetDictionary()
        {
            SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("Select * from Dictionary", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                dictionary.Add(dr[0].ToString(), dr[1].ToString());
            }
            dr.Close();
            conn.Close();
            return dictionary;
        }
    }
}
