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
    public partial class Form7 : Form
    {
        string tc_kopya2 = Form1.tc;
        public Form7()
        {
            InitializeComponent();
        }


        private void btn_kaydet_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect.Open();
                using (SqlCommand command = new SqlCommand("INSERT INTO Uye(kullanıcı_tc,kullanıcı_cinsiyet,kullanıcı_adı,kullanıcı_soyadı,kullanıcı_sifre,kullanıcı_doğumtarihi,kullanıcı_telefon,kullanıcı_eposta,kullanıcı_doğumyeri,kullanıcı_anneadı,kullanıcı_babaadı) VALUES (@kullanıcı_tc,@kullanıcı_cinsiyet,@kullanıcı_adı,@kullanıcı_soyadı,@kullanıcı_sifre,@kullanıcı_doğumtarihi,@kullanıcı_telefon,@kullanıcı_eposta,@kullanıcı_doğumyeri,@kullanıcı_anneadı,@kullanıcı_babaadı)", connect))
                {
                    command.Connection = connect;
                    command.Parameters.AddWithValue("@kullanıcı_tc", txtTc.Text);
                    command.Parameters.AddWithValue("@kullanıcı_adı", txtAd.Text);
                    command.Parameters.AddWithValue("@kullanıcı_soyadı", txtSoyad.Text);
                    command.Parameters.AddWithValue("@kullanıcı_sifre", txtSifre.Text);
                    command.Parameters.AddWithValue("@kullanıcı_doğumtarihi", dateTimePicker1.Text);
                    command.Parameters.AddWithValue("@kullanıcı_telefon", txtTelefon.Text);
                    command.Parameters.AddWithValue("@kullanıcı_eposta", txtEposta.Text);
                    command.Parameters.AddWithValue("@kullanıcı_doğumyeri", txtDoğumyeri.Text);
                    command.Parameters.AddWithValue("@kullanıcı_anneadı", txtAnne.Text);
                    command.Parameters.AddWithValue("@kullanıcı_babaadı", txtBaba.Text);
                    command.Parameters.AddWithValue("@kullanıcı_cinsiyet", comboBox1.SelectedItem);
                    command.ExecuteNonQuery();

                }
                connect.Close();
                if (txtSifre.Text != txtSifretekrar.Text)
                {
                    MessageBox.Show("Girdiğiniz Şifreler Uyuşmamaktadır. Lütfen Tekrar Giriniz.");
                }
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

            if (dateTimePicker1.Value > DateTime.Now)
            {
                MessageBox.Show("Seçtiğiniz Tarih Geçerli Değil");
            }
        }

    }
}

