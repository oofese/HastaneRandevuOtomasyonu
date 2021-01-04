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
    public partial class Form3 : Form
    {
        Form4 form4 = new Form4();

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            Text = "Randevu Sistemi";
            comboDoktor.Text = "Doktor Seciniz.";
            comboHastane.Text = "Hastane Seciniz.";
            comboIlce.Text = "Ilce Seciniz.";
            comboIller.Text = "Il Seciniz.";
            comboKlinik.Text = "Klinik Seciniz.";
            comboYer.Text = "Yer Seciniz.";
            //İlleri seçme
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect.Open();
                using (SqlCommand command = new SqlCommand("SELECT*FROM IL", connect))
                {
                    command.Connection = connect;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        comboIller.Items.Add(reader["ılAdı"]);
                    }
                }
                connect.Close();
            }
        }

        private void comboIller_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboIlce.Items.Clear();
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect.Open();
                using (SqlCommand command = new SqlCommand("EXEC Ilce_Secımı @val", connect))
                {
                    command.Connection = connect;
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@val", comboIller.SelectedItem.ToString());
                    SqlDataReader reader1;
                    reader1 = command.ExecuteReader();
                    while (reader1.Read())
                    {
                        comboIlce.Items.Add(reader1["ılceAdı"].ToString());
                    }
                }
                connect.Close();
            }


        }

        private void comboIlce_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboHastane.Items.Clear();
            using (SqlConnection connect1 = new SqlConnection())
            {
                connect1.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect1.Open();
                using (SqlCommand command1 = new SqlCommand("EXEC Hastane_Secim @val", connect1))
                {
                    command1.Connection = connect1;
                    command1.CommandType = CommandType.Text;
                    command1.Parameters.AddWithValue("@val", comboIlce.SelectedItem.ToString());
                    SqlDataReader reader2;
                    reader2 = command1.ExecuteReader();
                    while (reader2.Read())
                    {
                        comboHastane.Items.Add(reader2["hastaneAdı"]);
                    }
                }
                connect1.Close();
            }
        }

        private void comboHastane_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboKlinik.Items.Clear();
            using (SqlConnection connect2 = new SqlConnection())
            {
                connect2.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect2.Open();
                using (SqlCommand command2 = new SqlCommand("EXEC Klinik_Secim @val", connect2))
                {
                    command2.Connection = connect2;
                    command2.CommandType = CommandType.Text;
                    command2.Parameters.AddWithValue("@val", comboHastane.SelectedItem.ToString());
                    SqlDataReader reader3;
                    reader3 = command2.ExecuteReader();
                    while (reader3.Read())
                    {
                        comboKlinik.Items.Add(reader3["klinikAdı"]);
                    }
                }
                connect2.Close();
            }
        }

        private void comboKlinik_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboYer.Items.Clear();
            using (SqlConnection connect3 = new SqlConnection())
            {
                connect3.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect3.Open();
                using (SqlCommand command3 = new SqlCommand("EXEC Yer_Secim @val", connect3))
                {
                    command3.Connection = connect3;
                    command3.CommandType = CommandType.Text;
                    command3.Parameters.AddWithValue("@val", comboKlinik.SelectedItem.ToString());
                    SqlDataReader reader4;
                    reader4 = command3.ExecuteReader();
                    while (reader4.Read())
                    {
                        comboYer.Items.Add(reader4["yerAdı"]);
                    }
                }
                connect3.Close();
            }
        }

        private void comboYer_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboDoktor.Items.Clear();
            using (SqlConnection connect4 = new SqlConnection())
            {
                connect4.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect4.Open();
                using (SqlCommand command4 = new SqlCommand("EXEC Doktor_Secim @val", connect4))
                {
                    command4.Connection = connect4;
                    command4.CommandType = CommandType.Text;
                    command4.Parameters.AddWithValue("@val", comboKlinik.SelectedItem.ToString());
                    SqlDataReader reader5;
                    reader5 = command4.ExecuteReader();
                    while (reader5.Read())
                    {
                        comboDoktor.Items.Add(reader5["doktorAdı"]);
                    }
                }
                connect4.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboDoktor.Text = "Doktor Seciniz.";
            comboHastane.Text = "Hastane Seciniz.";
            comboIlce.Text = "Ilce Seciniz.";
            comboIller.Text = "Il Seciniz.";
            comboKlinik.Text = "Klinik Seciniz.";
            comboYer.Text = "Yer Seciniz.";
        }

        private void btn0830_Click(object sender, EventArgs e)
        {
            if (btn0830.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmiş Olduğunuz Saatteki Randevu Doludur.");
            }
            else
            {
                form4.f3 = this;
                form4.Show();


            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value < DateTime.Now)
            {
                MessageBox.Show("Seçtiğiniz Tarih Geçerli Değil");
            }
        }

        private void btn0840_Click(object sender, EventArgs e)
        {
            if (btn0840.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmiş Olduğunuz Saatteki Randevu Doludur.");
            }
            else
            {
                form4.f3 = this;
                form4.Show();


            }
        }

        private void btn0850_Click(object sender, EventArgs e)
        {
            if (btn0850.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmiş Olduğunuz Saatteki Randevu Doludur.");
            }
            else
            {
                form4.f3 = this;
                form4.Show();


            }
        }

        private void button28_Click(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            if (button16.BackColor == Color.Red)
            {
                MessageBox.Show("Seçmiş Olduğunuz Saatteki Randevu Doludur.");
            }
            else
            {
                form4.f3 = this;
                form4.Show();


            }
        }
    }
}

