﻿namespace personeltakipotomasyonu
{
    partial class frmMesaiEkle
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboPersonelAdsoyad = new System.Windows.Forms.ComboBox();
            this.dateTimeBaslangic = new System.Windows.Forms.DateTimePicker();
            this.maskedtxtBaslangic = new System.Windows.Forms.MaskedTextBox();
            this.maskedtxtBitis = new System.Windows.Forms.MaskedTextBox();
            this.dateTimeBitis = new System.Windows.Forms.DateTimePicker();
            this.txtMesaiSaatiUcreti = new System.Windows.Forms.TextBox();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnMesaiEkle = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Personel Ad Soyad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(45, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Başlangıç Saati:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(45, 137);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Bitiş Saati:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(45, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Mesai Saat Ücreti:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(45, 252);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Tutar:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(45, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Dönem:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(48, 365);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Açıklama:";
            // 
            // comboPersonelAdsoyad
            // 
            this.comboPersonelAdsoyad.FormattingEnabled = true;
            this.comboPersonelAdsoyad.Location = new System.Drawing.Point(48, 39);
            this.comboPersonelAdsoyad.Name = "comboPersonelAdsoyad";
            this.comboPersonelAdsoyad.Size = new System.Drawing.Size(222, 21);
            this.comboPersonelAdsoyad.TabIndex = 9;
            this.comboPersonelAdsoyad.SelectedIndexChanged += new System.EventHandler(this.comboPersonelAdsoyad_SelectedIndexChanged);
            // 
            // dateTimeBaslangic
            // 
            this.dateTimeBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBaslangic.Location = new System.Drawing.Point(48, 96);
            this.dateTimeBaslangic.Name = "dateTimeBaslangic";
            this.dateTimeBaslangic.Size = new System.Drawing.Size(116, 20);
            this.dateTimeBaslangic.TabIndex = 10;
            // 
            // maskedtxtBaslangic
            // 
            this.maskedtxtBaslangic.Location = new System.Drawing.Point(170, 96);
            this.maskedtxtBaslangic.Mask = "90:00";
            this.maskedtxtBaslangic.Name = "maskedtxtBaslangic";
            this.maskedtxtBaslangic.Size = new System.Drawing.Size(100, 20);
            this.maskedtxtBaslangic.TabIndex = 11;
            this.maskedtxtBaslangic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedtxtBaslangic.ValidatingType = typeof(System.DateTime);
            // 
            // maskedtxtBitis
            // 
            this.maskedtxtBitis.Location = new System.Drawing.Point(170, 156);
            this.maskedtxtBitis.Mask = "00:00";
            this.maskedtxtBitis.Name = "maskedtxtBitis";
            this.maskedtxtBitis.Size = new System.Drawing.Size(100, 20);
            this.maskedtxtBitis.TabIndex = 13;
            this.maskedtxtBitis.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.maskedtxtBitis.ValidatingType = typeof(System.DateTime);
            // 
            // dateTimeBitis
            // 
            this.dateTimeBitis.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeBitis.Location = new System.Drawing.Point(48, 156);
            this.dateTimeBitis.Name = "dateTimeBitis";
            this.dateTimeBitis.Size = new System.Drawing.Size(116, 20);
            this.dateTimeBitis.TabIndex = 12;
            // 
            // txtMesaiSaatiUcreti
            // 
            this.txtMesaiSaatiUcreti.Location = new System.Drawing.Point(48, 215);
            this.txtMesaiSaatiUcreti.Name = "txtMesaiSaatiUcreti";
            this.txtMesaiSaatiUcreti.Size = new System.Drawing.Size(222, 20);
            this.txtMesaiSaatiUcreti.TabIndex = 14;
            this.txtMesaiSaatiUcreti.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMesaiSaatiUcreti.TextChanged += new System.EventHandler(this.txtMesaiSaatiUcreti_TextChanged);
            // 
            // txtTutar
            // 
            this.txtTutar.Location = new System.Drawing.Point(48, 268);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(222, 20);
            this.txtTutar.TabIndex = 15;
            this.txtTutar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTutar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTutar_KeyPress);
            // 
            // comboAy
            // 
            this.comboAy.FormattingEnabled = true;
            this.comboAy.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboAy.Location = new System.Drawing.Point(48, 331);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(96, 21);
            this.comboAy.TabIndex = 16;
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(169, 331);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(100, 21);
            this.comboYil.TabIndex = 17;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(51, 381);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(222, 46);
            this.txtAciklama.TabIndex = 18;
            // 
            // btnMesaiEkle
            // 
            this.btnMesaiEkle.Location = new System.Drawing.Point(51, 433);
            this.btnMesaiEkle.Name = "btnMesaiEkle";
            this.btnMesaiEkle.Size = new System.Drawing.Size(97, 39);
            this.btnMesaiEkle.TabIndex = 19;
            this.btnMesaiEkle.Text = "Mesai Ekle";
            this.btnMesaiEkle.UseVisualStyleBackColor = true;
            this.btnMesaiEkle.Click += new System.EventHandler(this.btnMesaiEkle_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.Location = new System.Drawing.Point(173, 433);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(100, 39);
            this.btnCikis.TabIndex = 20;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(149, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(12, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "/";
            // 
            // frmMesaiEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(320, 509);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnMesaiEkle);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtTutar);
            this.Controls.Add(this.txtMesaiSaatiUcreti);
            this.Controls.Add(this.maskedtxtBitis);
            this.Controls.Add(this.dateTimeBitis);
            this.Controls.Add(this.maskedtxtBaslangic);
            this.Controls.Add(this.dateTimeBaslangic);
            this.Controls.Add(this.comboPersonelAdsoyad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmMesaiEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mesai Ekleme Sayfası";
            this.Load += new System.EventHandler(this.frmMesaiEkle_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboPersonelAdsoyad;
        private System.Windows.Forms.DateTimePicker dateTimeBaslangic;
        private System.Windows.Forms.MaskedTextBox maskedtxtBaslangic;
        private System.Windows.Forms.MaskedTextBox maskedtxtBitis;
        private System.Windows.Forms.DateTimePicker dateTimeBitis;
        private System.Windows.Forms.TextBox txtMesaiSaatiUcreti;
        private System.Windows.Forms.TextBox txtTutar;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnMesaiEkle;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Label label8;
    }
}