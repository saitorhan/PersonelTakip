namespace PersonelTakip
{
    partial class FormPersonel
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
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxDepartmanlar = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxAd = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxSoyad = new System.Windows.Forms.TextBox();
            this.dateTimePickerDagum = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.comboBoxCinsiyet = new System.Windows.Forms.ComboBox();
            this.maskedTextBoxKimlik = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.buttonKaydet = new System.Windows.Forms.Button();
            this.buttonIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Departman";
            // 
            // comboBoxDepartmanlar
            // 
            this.comboBoxDepartmanlar.FormattingEnabled = true;
            this.comboBoxDepartmanlar.Location = new System.Drawing.Point(132, 12);
            this.comboBoxDepartmanlar.Name = "comboBoxDepartmanlar";
            this.comboBoxDepartmanlar.Size = new System.Drawing.Size(319, 21);
            this.comboBoxDepartmanlar.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(22, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Adı";
            // 
            // textBoxAd
            // 
            this.textBoxAd.Location = new System.Drawing.Point(132, 39);
            this.textBoxAd.Name = "textBoxAd";
            this.textBoxAd.Size = new System.Drawing.Size(319, 20);
            this.textBoxAd.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Soyadı";
            // 
            // textBoxSoyad
            // 
            this.textBoxSoyad.Location = new System.Drawing.Point(132, 65);
            this.textBoxSoyad.Name = "textBoxSoyad";
            this.textBoxSoyad.Size = new System.Drawing.Size(319, 20);
            this.textBoxSoyad.TabIndex = 3;
            // 
            // dateTimePickerDagum
            // 
            this.dateTimePickerDagum.Location = new System.Drawing.Point(132, 91);
            this.dateTimePickerDagum.Name = "dateTimePickerDagum";
            this.dateTimePickerDagum.Size = new System.Drawing.Size(319, 20);
            this.dateTimePickerDagum.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Doğum Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 120);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Cinsiyet";
            // 
            // comboBoxCinsiyet
            // 
            this.comboBoxCinsiyet.FormattingEnabled = true;
            this.comboBoxCinsiyet.Items.AddRange(new object[] {
            "Kadın",
            "Erkek"});
            this.comboBoxCinsiyet.Location = new System.Drawing.Point(132, 117);
            this.comboBoxCinsiyet.Name = "comboBoxCinsiyet";
            this.comboBoxCinsiyet.Size = new System.Drawing.Size(319, 21);
            this.comboBoxCinsiyet.TabIndex = 1;
            // 
            // maskedTextBoxKimlik
            // 
            this.maskedTextBoxKimlik.Location = new System.Drawing.Point(132, 144);
            this.maskedTextBoxKimlik.Mask = "00000000000";
            this.maskedTextBoxKimlik.Name = "maskedTextBoxKimlik";
            this.maskedTextBoxKimlik.Size = new System.Drawing.Size(319, 20);
            this.maskedTextBoxKimlik.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Kimlik Nu";
            // 
            // buttonKaydet
            // 
            this.buttonKaydet.Location = new System.Drawing.Point(376, 170);
            this.buttonKaydet.Name = "buttonKaydet";
            this.buttonKaydet.Size = new System.Drawing.Size(75, 23);
            this.buttonKaydet.TabIndex = 6;
            this.buttonKaydet.Text = "Kaydet";
            this.buttonKaydet.UseVisualStyleBackColor = true;
            this.buttonKaydet.Click += new System.EventHandler(this.buttonKaydet_Click);
            // 
            // buttonIptal
            // 
            this.buttonIptal.Location = new System.Drawing.Point(295, 170);
            this.buttonIptal.Name = "buttonIptal";
            this.buttonIptal.Size = new System.Drawing.Size(75, 23);
            this.buttonIptal.TabIndex = 6;
            this.buttonIptal.Text = "İptal";
            this.buttonIptal.UseVisualStyleBackColor = true;
            // 
            // FormPersonel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 210);
            this.Controls.Add(this.buttonIptal);
            this.Controls.Add(this.buttonKaydet);
            this.Controls.Add(this.maskedTextBoxKimlik);
            this.Controls.Add(this.dateTimePickerDagum);
            this.Controls.Add(this.textBoxSoyad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxAd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCinsiyet);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.comboBoxDepartmanlar);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormPersonel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Personel";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxDepartmanlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxAd;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxSoyad;
        private System.Windows.Forms.DateTimePicker dateTimePickerDagum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox comboBoxCinsiyet;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxKimlik;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button buttonKaydet;
        private System.Windows.Forms.Button buttonIptal;
    }
}