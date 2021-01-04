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
    public partial class Form8 : Form
    {
        string kopya_tc5 = Form1.tc;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect.Open();
                using (SqlCommand command = new SqlCommand("SELECT*FROM Ilac WHERE hastaTc='" + kopya_tc5 + "'", connect))
                {
                    command.Connection = connect;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txttc.Text = reader["hastaTc"].ToString();
                        txtrecete.Text = reader["receteNumarası"].ToString();
                        txtilac.Text = reader["ilacAdı"].ToString();
                        txttarih.Text = reader["tarih"].ToString();

                    }
                }
                connect.Close();
            }
        }
    }
}

