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
    public partial class FormPersoneller : Form
    {
        public FormPersoneller()
        {
            InitializeComponent();
        }

        private void buttonEkle_Click(object sender, EventArgs e)
        {
            FormPersonel formPersonel = new FormPersonel();
            formPersonel.ShowDialog();

            if (formPersonel.Sonuc > 0)
            {
                VerileriYenile();
            }
        }

        private void Departmanlar_Load(object sender, EventArgs e)
        {
            VerileriYenile();
        }

        void VerileriYenile()
        {
            SqlConnection sqlConnection = GenelTanimlamalar.SqlBaglanti;
            SqlCommand sqlCommand = new SqlCommand("select c.Id, c.Ad, c.Soyad, c.DogumTarih, c.TcNo, c.Cinsiyet, d.Ad DepartmanAd from Calisanlar c join Departmanlar d on c.DepartmanId = d.Id", sqlConnection);
            try
            {
                sqlConnection.Open();
                dataGridView1.Rows.Clear();
                SqlDataReader dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    dataGridView1.Rows.Add(dataReader.GetInt32(0), dataReader.GetString(1), dataReader.GetString(2),
                        dataReader.GetDateTime(3).ToString("dd.MM.yyyy"), dataReader.GetString(4), dataReader.GetBoolean(5) ? "Erkek" : "Kadın",
                        dataReader.GetString(6));
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Personel listesi alınamadı", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

            int id =  (int)dataGridView1.SelectedRows[0].Cells[0].Value;
            FormPersonel formPersonel = new FormPersonel(id);
            formPersonel.ShowDialog();

            if (formPersonel.Sonuc > 0)
            {
                VerileriYenile();
            }
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                return;
            }

            int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

            if (MessageBox.Show($"{dataGridView1.SelectedRows[0].Cells[1].Value} {dataGridView1.SelectedRows[0].Cells[2].Value} silinecek, bu işlem geri alınamaz. Onaylıyor musunuz?", "Uyarı!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                return;
            }

            SqlConnection sqlConnection = GenelTanimlamalar.SqlBaglanti;
            SqlCommand sqlCommand = new SqlCommand("delete Calisanlar where Id = @id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", id);


            try
            {
                sqlConnection.Open();
                int sonuc = sqlCommand.ExecuteNonQuery();
                MessageBox.Show($"{dataGridView1.SelectedRows[0].Cells[1].Value} {dataGridView1.SelectedRows[0].Cells[2].Value} silin{(sonuc > 0 ? "di" : "emedi")}", sonuc > 0 ? "Bilgilendir" : "Hata", MessageBoxButtons.OK, sonuc > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (sonuc > 0)
                {
                    VerileriYenile();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Çalışan silinemedi", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
