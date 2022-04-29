using System;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text;

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


           

            Application.Run(new DictionaryApp(GetDictionary()));
        }

        public static SortedDictionary<string, string> GetDictionary()
        {
            SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
            FileStream stream = new FileStream("WordPairs.txt", FileMode.OpenOrCreate, FileAccess.Read);
            StreamReader reader = new StreamReader(stream);

            string[] text;
            string line = reader.ReadLine();
            while (line != null)
            {
                text = line.Split('-');;
                dictionary.Add(text[0].ToString(), text[1].ToString());
                line = reader.ReadLine();
            }
            reader.Close();           
            stream.Close();
            return dictionary;
        }
    }
}
