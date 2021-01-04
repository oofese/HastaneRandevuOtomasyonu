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
    public partial class Form4 : Form
    {
        public Form3 f3;
        string tc_kopya = Form1.tc;


        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            Text = "Randevu Kaydet";
            txt_hastane.Text = (string)f3.comboHastane.SelectedItem;
            txt_klinik.Text = (string)f3.comboIller.SelectedItem;
            txt_doktor.Text = (string)f3.comboDoktor.SelectedItem;
            txt_muayene.Text = (string)f3.comboYer.SelectedItem;
            txt_randevu.Text = Convert.ToString(f3.dateTimePicker1.Text);
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect.Open();
                using (SqlCommand command = new SqlCommand("SELECT*FROM Uye WHERE kullanıcı_tc='" + tc_kopya + "'", connect))
                {
                    command.Connection = connect;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    if (reader.Read())
                    {
                        txt_ad.Text = reader["kullanıcı_adı"].ToString();
                        txt_soyad.Text = reader["kullanıcı_soyadı"].ToString();
                        txt_doğumtarihi.Text = reader["kullanıcı_doğumtarihi"].ToString();
                        txt_telefon.Text = reader["kullanıcı_telefon"].ToString();
                        txt_eposta.Text = reader["kullanıcı_tc"].ToString();
                        txt_cinsiyet.Text = reader["kullanıcı_cinsiyet"].ToString();
                    }
                }
                connect.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Randevular(hastaneAdı,klinikAdı,yerAdı,doktorAdı,tarih,hastaAdı,hastaSoyadı,hastaCinsiyet,hastaDoğumtarihi,hastaTelefon,hastaEposta,hastaTc) VALUES (@hastaneAdı,@klinikAdı,@yerAdı,@doktorAdı,@tarih,@hastaAdı,@hastaSoyadı,@hastaCinsiyet,@hastaDoğumtarihi,@hastaTelefon,@hastaEposta,@hastaTc)", connect))
                {
                    command.Connection = connect;
                    command.Parameters.AddWithValue("@hastaneAdı", txt_hastane.Text);
                    command.Parameters.AddWithValue("@klinikAdı", txt_klinik.Text);
                    command.Parameters.AddWithValue("@yerAdı", txt_muayene.Text);
                    command.Parameters.AddWithValue("@doktorAdı", txt_doktor.Text);
                    command.Parameters.AddWithValue("@tarih", txt_randevu.Text);
                    command.Parameters.AddWithValue("@hastaAdı", txt_ad.Text);
                    command.Parameters.AddWithValue("@hastaSoyadı", txt_soyad.Text);
                    command.Parameters.AddWithValue("@hastaCinsiyet", txt_cinsiyet.Text);
                    command.Parameters.AddWithValue("@hastaDoğumtarihi", txt_doğumtarihi.Text);
                    command.Parameters.AddWithValue("@hastaTelefon", txt_telefon.Text);
                    command.Parameters.AddWithValue("@hastaEposta", txt_eposta.Text);
                    command.Parameters.AddWithValue("@hastaTc", tc_kopya);
                    command.ExecuteNonQuery();

                }
                connect.Close();
            }
        }
    }
}

