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
    public partial class Form6 : Form

    {
        string tc_kopya1 = Form1.tc;
        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect.Open();
                using (SqlCommand command = new SqlCommand("SELECT*FROM Uye WHERE kullanıcı_tc='" + tc_kopya1 + "'", connect))
                {
                    command.Connection = connect;
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader;
                    reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        txttc.Text = reader["kullanıcı_tc"].ToString();
                        txtad.Text = reader["kullanıcı_adı"].ToString();
                        txtsoyad.Text = reader["kullanıcı_soyadı"].ToString();
                        txtdoğumtarihi.Text = reader["kullanıcı_doğumtarihi"].ToString();
                        txttelefon.Text = reader["kullanıcı_telefon"].ToString();
                        txtdoğumyeri.Text = reader["kullanıcı_doğumyeri"].ToString();
                        txtcinsiyet.Text = reader["kullanıcı_cinsiyet"].ToString();
                        txtanne.Text = reader["kullanıcı_anneadı"].ToString();
                        txtbaba.Text = reader["kullanıcı_babaadı"].ToString();
                        txteposta.Text = reader["kullanıcı_eposta"].ToString();
                    }

                }
                connect.Close();
            }
        }

        private void btnkaydetkisisel_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Uye SET kullanıcı_adı=@kullanıcı_adı,kullanıcı_soyadı=@kullanıcı_soyadı,kullanıcı_doğumyeri=@kullanıcı_doğumyeri,kullanıcı_doğumtarihi=@kullanıcı_doğumtarihi,kullanıcı_anneadı=@kullanıcı_anneadı,kullanıcı_babaadı=@kullanıcı_babaadı", connect))
                {
                    command.Connection = connect;
                    command.Parameters.AddWithValue("@kullanıcı_adı", txtad.Text);
                    command.Parameters.AddWithValue("@kullanıcı_soyadı", txtsoyad.Text);
                    command.Parameters.AddWithValue("@kullanıcı_doğumtarihi", txtdoğumtarihi.Text);
                    command.Parameters.AddWithValue("@kullanıcı_doğumyeri", txtdoğumyeri.Text);
                    command.Parameters.AddWithValue("@kullanıcı_anneadı", txtanne.Text);
                    command.Parameters.AddWithValue("@kullanıcı_babaadı", txtbaba.Text);
                    command.ExecuteNonQuery();
                }
                connect.Close();
            }


        }

        private void btnSıfre_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Uye SET kullanıcı_sifre=@kullanıcı_sifre", connect))
                {
                    command.Connection = connect;
                    if (txtyenisifre.Text == txtsifretekrar.Text)
                    {
                        command.Parameters.AddWithValue("@kullanıcı_sifre", txtyenisifre.Text);
                        command.ExecuteNonQuery();
                    }

                    else
                    {
                        MessageBox.Show("Lütfen Şifrelerinizi Kontrol Ediniz.");
                    }


                }
                connect.Close();
            }
        }

        private void btniletisim_Click(object sender, EventArgs e)
        {
            using (SqlConnection connect = new SqlConnection())
            {
                connect.ConnectionString = @"Data Source = DESKTOP-70NS63R; Initial Catalog = deneme; Integrated Security = True; Connect Timeout = 15; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False ";
                connect.Open();
                using (SqlCommand command = new SqlCommand("UPDATE Uye SET kullanıcı_telefon=@kullanıcı_telefon,kullanıcı_eposta=@kullanıcı_eposta", connect))
                {
                    command.Connection = connect;
                    command.Parameters.AddWithValue("@kullanıcı_telefon", txttelefon.Text);
                    command.Parameters.AddWithValue("@kullanıcı_eposta", txteposta.Text);
                    command.ExecuteNonQuery();



                }
                connect.Close();
            }
        }
    }
}


