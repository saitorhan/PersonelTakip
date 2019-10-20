using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PersonelTakip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void departmanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Departmanlar departmanlar = new Departmanlar();
            departmanlar.MdiParent = this;
            departmanlar.Show();
        }

        private void personellerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormPersoneller formPersoneller = new FormPersoneller();
            formPersoneller.MdiParent = this;
            formPersoneller.Show();
        }
    }
}
