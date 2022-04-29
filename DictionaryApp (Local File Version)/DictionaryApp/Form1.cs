using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace DictionaryApp
{
    public partial class DictionaryApp : Form
    {
        public SortedDictionary<string, string> _dictionary { get; set; }
        public DictionaryApp(SortedDictionary<string,string> dictionary)
        {
            _dictionary = dictionary;
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            lstWords.DataSource = _dictionary.Keys.ToList();           
        }

        private void lstWords_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtEnglish.Text = lstWords.SelectedItem.ToString();
            _dictionary.TryGetValue(txtEnglish.Text, out string turkish);
            txtTurkish.Text = turkish;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _dictionary.Add(txtNewEnglish.Text, txtNewTurkish.Text);
            lstWords.DataSource = _dictionary.Keys.ToList();
            StreamWriter writer = new StreamWriter("WordPairs.txt", true);
            writer.WriteLine(txtNewEnglish.Text + "-" + txtNewTurkish.Text);
            writer.Flush();
            writer.Close();          
        }

        private void txtNewTurkish_MouseClick(object sender, MouseEventArgs e)
        {
            txtNewTurkish.Clear();
        }

        private void txtNewEnglish_MouseClick(object sender, MouseEventArgs e)
        {
            txtNewEnglish.Clear();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            SortedDictionary<string, string> dictionary = new SortedDictionary<string, string>();
            List<KeyValuePair<string,string>> list = _dictionary.Where(x => x.Key.ToLower().Contains(txtSearch.Text.ToLower())).ToList();
            foreach (KeyValuePair<string,string> pair in list)
            {
                dictionary.Add(pair.Key, pair.Value);
            }                  
            lstWords.DataSource= dictionary.Keys.ToList();

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _dictionary.Remove(txtEnglish.Text);
            StreamWriter writer = new StreamWriter("WordPairs.txt");
            foreach(var item in _dictionary)
            {
                writer.WriteLine(item.Key + "-" + item.Value);
            }          
            writer.Flush();
            writer.Close();
            lstWords.DataSource = _dictionary.Keys.ToList();
        }
    }
}
