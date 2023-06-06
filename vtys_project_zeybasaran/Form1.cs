using System.Data.SqlClient;
using System;
using System.Windows.Forms;

namespace vtys_project_zeybasaran
{
    public partial class girisSayfa : Form
    {
        public string conString = "Data Source=ZEYBASARAN\\SQLZEZE;Initial Catalog=satirsatir;Integrated Security=True";
        public girisSayfa()
        {
            InitializeComponent();
        }

        private void girisButton_Click(object sender, EventArgs e)
        {
            anaSayfa anaSayfa = new anaSayfa();
            string kullaniciAd = txtKullaniciAdi.Text;

            string sifre = txtSifre.Text;

            if (KullaniciDogrula(kullaniciAd, sifre))
            {

                anaSayfa.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Geçersiz kullanýcý adý veya þifre!");
            }
        }
        private bool KullaniciDogrula(string kullaniciAd, string sifre)
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();

                    string query = "SELECT COUNT(*) FROM kullanici WHERE kullaniciAd = @kullaniciAd AND sifre = @sifre";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciAd", kullaniciAd);
                        command.Parameters.AddWithValue("@sifre", sifre);

                        int kullaniciSayisi = (int)command.ExecuteScalar();

                        if (kullaniciSayisi > 0)
                        {
                            return true; // Kullanýcý doðrulandý
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata oluþtu: " + ex.Message);
            }

            return false; // Kullanýcý doðrulanmadý veya hata oluþtu
        }
    }
}

