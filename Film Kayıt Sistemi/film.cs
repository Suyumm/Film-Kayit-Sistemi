using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;


namespace Film_Kayıt_Sistemi
{
    public partial class film : Form
    {
        public film()
        {
            InitializeComponent();
        }

        OleDbConnection fiydan = new OleDbConnection("Provider=Microsoft.ACE.OleDb.12.0;Data Source=" + Application.StartupPath + "\\Personel.accdb");

        private void button1_Click(object sender, EventArgs e)
        {
            fiydan.Open();
            OleDbCommand kaydet = new OleDbCommand("insert into Ders values ('" + textBox2.Text + "','" + textBox1.Text + "','" + textBox3.Text + "','" + comboBox1.Text + "')", fiydan);
            kaydet.ExecuteNonQuery();
            fiydan.Close();

            MessageBox.Show("Kaydedildi.");

            kayit();
        }
    }
}
