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

namespace PersonelTakip
{
    public partial class Departmanlar : Form
    {
        public Departmanlar()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            FormDepartman formDepartman = new FormDepartman();
            formDepartman.ShowDialog();
            VerileriYenile();
        }

        private void Departmanlar_Load(object sender, EventArgs e)
        {
            VerileriYenile();
        }

        void VerileriYenile()
        {
            SqlConnection sqlConnection = GenelTanimlamalar.SqlBaglanti;
            SqlCommand sqlCommand = new SqlCommand("select Id, Ad from Departmanlar", sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                dataGridView1.Rows.Clear();
                while (sqlDataReader.Read())
                {
                    dataGridView1.Rows.Add(sqlDataReader.GetInt32(0), sqlDataReader.GetString(1));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Departmanlar okunamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow dataGridViewCell = dataGridView1.SelectedRows[0];
            int id = (int) dataGridViewCell.Cells[0].Value;

            string ad = dataGridViewCell.Cells[1].Value.ToString();
            FormDepartman formDepartman = new FormDepartman(id, ad);
            formDepartman.ShowDialog();
            VerileriYenile();
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            DataGridViewRow dataGridViewRow = dataGridView1.SelectedRows[0];
            int id = (int)dataGridViewRow.Cells[0].Value;

            if (MessageBox.Show($"{dataGridViewRow.Cells[1].Value} silincek, onaylıyor musunuz?", "Soru", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            SqlConnection sqlConnection = GenelTanimlamalar.SqlBaglanti;
            SqlCommand sqlCommand = new SqlCommand("delete Departmanlar where Id = @i", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@i", id);
            try
            {
                sqlConnection.Open();
                int sonuc = sqlCommand.ExecuteNonQuery();
                MessageBox.Show( $"{dataGridViewRow.Cells[1].Value} silin{(sonuc > 0 ? "di":"emedi")}", sonuc > 0 ? "Bilgilendir" : "Hata", MessageBoxButtons.OK, sonuc > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (sonuc > 0)
                {
                    VerileriYenile();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Departmanlar silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }

        }
    }
}
