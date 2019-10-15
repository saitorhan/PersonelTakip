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
    public partial class FormDepartman : Form
    {
        private int Id;
        public FormDepartman()
        {
            InitializeComponent();
        }
        public FormDepartman(int id, string ad)
        {
            InitializeComponent();
            Id = id;
            textBoxAd.Text = ad;
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = GenelTanimlamalar.SqlBaglanti;
            SqlCommand sqlKomut;
            if (Id > 0)
            {
                sqlKomut = new SqlCommand("update Departmanlar set Ad = @a where Id = @i", sqlConnection);
                sqlKomut.Parameters.AddWithValue("@i", Id);
            }
            else
            {
                sqlKomut = new SqlCommand("Insert INTO Departmanlar(Ad) values(@a)", sqlConnection);
            }
             
            sqlKomut.Parameters.AddWithValue("@a", textBoxAd.Text);

            try
            {
                sqlConnection.Open();
                int i = sqlKomut.ExecuteNonQuery();
                MessageBox.Show($"{textBoxAd.Text} departmanı kaydedil{(i > 0 ? "di" : "emedi")}", i > 0 ? "Bilgilendirme": "Hata", MessageBoxButtons.OK, i > 0 ? MessageBoxIcon.Information : MessageBoxIcon.Error);
                if (i > 0)
                {
                    Close();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show($"{textBoxAd.Text} departmanı kaydedilemedi)", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlConnection.State != ConnectionState.Closed)
                {
                    sqlConnection.Close();
                }
            }
        }

        private void buttonIptal_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
