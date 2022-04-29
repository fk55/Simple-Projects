using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

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
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("INSERT INTO Dictionary (English,Turkish) values(@eng,@tur)", conn);
            cmd.Parameters.AddWithValue("@eng",txtNewEnglish.Text);
            cmd.Parameters.AddWithValue("@tur", txtNewTurkish.Text);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            lstWords.DataSource = _dictionary.Keys.ToList();
            txtNewEnglish.Clear();
            txtNewTurkish.Clear();
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
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand($"SELECT * FROM Dictionary where English LIKE '{txtSearch.Text}%'", conn);
            conn.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            
            while (dr.Read())
            {
                dictionary.Add(dr[0].ToString(), dr[1].ToString());
            }

            dr.Close();
            conn.Close();           
            lstWords.DataSource= dictionary.Keys.ToList();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            SqlConnection conn = db.conn();
            SqlCommand cmd = new SqlCommand("DELETE FROM Dictionary WHERE (English)=@eng", conn);
            cmd.Parameters.AddWithValue("@eng", lstWords.SelectedItem.ToString());
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            _dictionary.Remove(lstWords.SelectedItem.ToString());
            lstWords.DataSource = _dictionary.Keys.ToList();
        }
    }
}
