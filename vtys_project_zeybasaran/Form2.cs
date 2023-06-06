using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*string conString = "Data Source=ZEYBASARAN\\SQLZEZE;Initial Catalog=satirsatir;Integrated Security=True";
SqlConnection connection = new SqlConnection(conString);
*/
namespace vtys_project_zeybasaran
{
    public partial class anaSayfa : Form
    {
        string conString = "Data Source=ZEYBASARAN\\SQLZEZE;Initial Catalog=satirsatir;Integrated Security=True";



        public anaSayfa()
        {
            InitializeComponent();
        }




        private void sorgu3_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();
            string procedureName = "kitaplar"; // Oluşturduğunuz Stored Procedure adı
            SqlCommand command = new SqlCommand(procedureName, connection);
            command.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            connection.Close();
            dataGridView1.DataSource = table;

        }

        private void sorgu1_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT ad FROM yazar";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void sorgu2_Click(object sender, EventArgs e)
        {

            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT yayineviAd FROM yayinevi";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void edebiyat_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM edebiyat";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void rus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM rus";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void turk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM turk";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void deneme_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM deneme";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void tiyatro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM tiyatro";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void polisiye_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM polisiye";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void bilimkurgu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM bilimkurgu";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void cocuk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM cocuk";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void kucukcocuk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM kucukCocuk";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void buyukCocuk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM buyukCocuk";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void sinav_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM sinav";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void kpss_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM kpss";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void yks_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM yks";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void yds_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM yds";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }

        private void lgs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM lgs";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void sepetButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string kitapAd = dataGridView1.SelectedRows[0].Cells["kitapAd"].Value.ToString();
                string fiyat = dataGridView1.SelectedRows[0].Cells["fiyat"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "INSERT INTO sepet (kitapAd, tutar) VALUES (@kitapAd, @fiyat)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kitapAd", kitapAd);
                        command.Parameters.AddWithValue("@fiyat", fiyat);
                        int rowsAffected = command.ExecuteNonQuery();


                    }
                }
            }

        }

        private void favoriButton_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string kitapAd = dataGridView1.SelectedRows[0].Cells["kitapAd"].Value.ToString();
                string fiyat = dataGridView1.SelectedRows[0].Cells["fiyat"].Value.ToString();

                using (SqlConnection connection = new SqlConnection(conString))
                {
                    connection.Open();
                    string query = "INSERT INTO favorilist (kitapAd, tutar) VALUES (@kitapAd, @fiyat)";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kitapAd", kitapAd);
                        command.Parameters.AddWithValue("@fiyat", fiyat);
                        int rowsAffected = command.ExecuteNonQuery();


                    }
                }
            }
        }

        private void sepet_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM sepet";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;

        }

        private void favori_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(conString);
            connection.Open();

            string query = $"SELECT * FROM favorilist";
            SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
            DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            dataGridView1.DataSource = dataTable;
        }
    }
}

