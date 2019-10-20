﻿namespace PersonelTakip
{
    partial class FormPersoneller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.buttonSil = new System.Windows.Forms.Button();
            this.buttonGuncelle = new System.Windows.Forms.Button();
            this.buttonEkle = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Id_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ad_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soyad_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dogum_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tc_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cinsiyet_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departman_c = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.buttonSil);
            this.panel1.Controls.Add(this.buttonGuncelle);
            this.panel1.Controls.Add(this.buttonEkle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(728, 72);
            this.panel1.TabIndex = 0;
            // 
            // buttonSil
            // 
            this.buttonSil.Location = new System.Drawing.Point(174, 12);
            this.buttonSil.Name = "buttonSil";
            this.buttonSil.Size = new System.Drawing.Size(75, 45);
            this.buttonSil.TabIndex = 0;
            this.buttonSil.Text = "Personel Sil";
            this.buttonSil.UseVisualStyleBackColor = true;
            this.buttonSil.Click += new System.EventHandler(this.buttonSil_Click);
            // 
            // buttonGuncelle
            // 
            this.buttonGuncelle.Location = new System.Drawing.Point(93, 12);
            this.buttonGuncelle.Name = "buttonGuncelle";
            this.buttonGuncelle.Size = new System.Drawing.Size(75, 45);
            this.buttonGuncelle.TabIndex = 0;
            this.buttonGuncelle.Text = "Personel Güncelle";
            this.buttonGuncelle.UseVisualStyleBackColor = true;
            this.buttonGuncelle.Click += new System.EventHandler(this.buttonGuncelle_Click);
            // 
            // buttonEkle
            // 
            this.buttonEkle.Location = new System.Drawing.Point(12, 12);
            this.buttonEkle.Name = "buttonEkle";
            this.buttonEkle.Size = new System.Drawing.Size(75, 45);
            this.buttonEkle.TabIndex = 0;
            this.buttonEkle.Text = "Yeni Personel";
            this.buttonEkle.UseVisualStyleBackColor = true;
            this.buttonEkle.Click += new System.EventHandler(this.buttonEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id_c,
            this.Ad_c,
            this.soyad_c,
            this.dogum_c,
            this.tc_c,
            this.cinsiyet_c,
            this.departman_c});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(728, 549);
            this.dataGridView1.TabIndex = 1;
            // 
            // Id_c
            // 
            this.Id_c.HeaderText = "Id";
            this.Id_c.Name = "Id_c";
            this.Id_c.ReadOnly = true;
            this.Id_c.Visible = false;
            // 
            // Ad_c
            // 
            this.Ad_c.HeaderText = "Personel Adı";
            this.Ad_c.Name = "Ad_c";
            this.Ad_c.ReadOnly = true;
            // 
            // soyad_c
            // 
            this.soyad_c.HeaderText = "Personel Soyadı";
            this.soyad_c.Name = "soyad_c";
            this.soyad_c.ReadOnly = true;
            // 
            // dogum_c
            // 
            this.dogum_c.HeaderText = "Doğum Tarihi";
            this.dogum_c.Name = "dogum_c";
            this.dogum_c.ReadOnly = true;
            // 
            // tc_c
            // 
            this.tc_c.HeaderText = "Kimlik Num";
            this.tc_c.Name = "tc_c";
            this.tc_c.ReadOnly = true;
            // 
            // cinsiyet_c
            // 
            this.cinsiyet_c.HeaderText = "Cinsiyeti";
            this.cinsiyet_c.Name = "cinsiyet_c";
            this.cinsiyet_c.ReadOnly = true;
            // 
            // departman_c
            // 
            this.departman_c.HeaderText = "Departman";
            this.departman_c.Name = "departman_c";
            this.departman_c.ReadOnly = true;
            // 
            // FormPersoneller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(728, 621);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Name = "FormPersoneller";
            this.Text = "Personeller";
            this.Load += new System.EventHandler(this.Departmanlar_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button buttonSil;
        private System.Windows.Forms.Button buttonGuncelle;
        private System.Windows.Forms.Button buttonEkle;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ad_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn soyad_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn dogum_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn tc_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn cinsiyet_c;
        private System.Windows.Forms.DataGridViewTextBoxColumn departman_c;
    }
}