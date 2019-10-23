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
    public partial class FormPersonel : Form
    {
        public int Sonuc { get; set; }
        public int Id { get; set; }
        public FormPersonel()
        {
            InitializeComponent();
            DepartanListesiAl();
            dateTimePickerDagum.MaxDate = DateTime.Today;
            comboBoxCinsiyet.SelectedIndex = 0;
        }
        public FormPersonel(int id)
        {
            InitializeComponent();
            DepartanListesiAl();
            Id = id;
            dateTimePickerDagum.MaxDate = DateTime.Today;
            comboBoxCinsiyet.SelectedIndex = 0;

            GuncellenecekPersonelGetir();
        }

        private void GuncellenecekPersonelGetir()
        {
            SqlConnection sqlConnection = GenelTanimlamalar.SqlBaglanti;
            SqlCommand sqlCommand = new SqlCommand("SELECT TOP 1 [Id] ,[Ad] ,[Soyad] ,[DogumTarih] ,[Cinsiyet] ,[TcNo] ,[DepartmanId] FROM[PersonelTakip].[dbo].[Calisanlar] where Id = @id", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@id", Id);
            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
              

                while(sqlDataReader.Read())
                {
                    textBoxAd.Text = sqlDataReader.GetString(1);
                    textBoxSoyad.Text = sqlDataReader.GetString(2);
                    dateTimePickerDagum.Value = sqlDataReader.GetDateTime(3);
                    comboBoxCinsiyet.SelectedIndex = Convert.ToInt32(sqlDataReader.GetBoolean(4));
                    maskedTextBoxKimlik.Text = sqlDataReader.GetString(5);
                    int depId = sqlDataReader.GetInt32(6);

                    foreach (Departman item in comboBoxDepartmanlar.Items)
                    {
                        if (item.Id == depId)
                        {
                            comboBoxDepartmanlar.SelectedItem = item;
                            break;
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }

        void DepartanListesiAl()
        {
            SqlConnection sqlConnection = GenelTanimlamalar.SqlBaglanti;
            SqlCommand sqlCommand = new SqlCommand("select Id, Ad from Departmanlar", sqlConnection);

            try
            {
                sqlConnection.Open();
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    Departman departman = new Departman {Id = sqlDataReader.GetInt32(0), Ad = sqlDataReader.GetString(1)};
                    comboBoxDepartmanlar.Items.Add(departman);
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

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = GenelTanimlamalar.SqlBaglanti;
            SqlCommand sqlCommand;

            if (Id > 0)
            {
                sqlCommand = new SqlCommand("update Calisanlar set [Ad] = @a, [Soyad] = @s,  [DogumTarih] = @d, [Cinsiyet] = @c, [TcNo] = @t, [DepartmanId] = @dt where Id = @id", sqlConnection);
                sqlCommand.Parameters.AddWithValue("@id", Id);
            }
            else
            {
                sqlCommand = new SqlCommand("INSERT Calisanlar([Ad], [Soyad], [DogumTarih], [Cinsiyet], [TcNo], [DepartmanId]) values(@a, @s, @d, @c, @t, @dt)", sqlConnection);
            }
                
              

            sqlCommand.Parameters.AddWithValue("@a", textBoxAd.Text);
            sqlCommand.Parameters.AddWithValue("@s", textBoxSoyad.Text);
            sqlCommand.Parameters.AddWithValue("@d", dateTimePickerDagum.Value);
            sqlCommand.Parameters.AddWithValue("@c", Convert.ToBoolean(comboBoxCinsiyet.SelectedIndex));
            sqlCommand.Parameters.AddWithValue("@t", maskedTextBoxKimlik.Text);
            sqlCommand.Parameters.AddWithValue("@dt", (comboBoxDepartmanlar.SelectedItem as Departman).Id);
            try
            {
                sqlConnection.Open();
                Sonuc = sqlCommand.ExecuteNonQuery();
            }
            catch (Exception exception)
            {
                Sonuc = 0;
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }

            MessageBox.Show($"Kayıt başarı{(Sonuc > 0 ? "lı" : "sız")} oldu.", Sonuc > 0 ? "Bilgilendirme" : "Hata",MessageBoxButtons.OK , Sonuc > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
            if (Sonuc > 0)
            {
                Close();
            }
        }
    }
}
