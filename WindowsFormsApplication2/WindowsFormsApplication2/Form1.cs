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

namespace WindowsFormsApplication2
{
    public partial class Form1 : Form
    {
        public static string tc;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect.Open();
                using (SqlCommand command = new SqlCommand("SELECT*FROM Uye WHERE kullanıcı_tc='" + textBoxtc.Text + "'AND kullanıcı_sifre='" + textBoxsifre.Text + "'", connect))
                {
                    SqlDataReader reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        Form2 form2 = new Form2();
                        form2.Show();
                    }
                    else
                    {
                        label3.Visible = true;
                        label3.Text = "Girdiğiniz T.C. Kimlik Numarası ya da Parola Hatalıdır.\nLütfen Tekrar Deneyiniz.";
                    }
                    tc = textBoxtc.Text;
                }
                connect.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form7 form7 = new Form7();
            form7.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}

