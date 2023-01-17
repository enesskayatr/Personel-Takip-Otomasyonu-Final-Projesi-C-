namespace personeltakipotomasyonu
{
    partial class frmPrimEkle
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimEkle));
            this.radioKisiyeOzel = new System.Windows.Forms.RadioButton();
            this.radioTumPersoneller = new System.Windows.Forms.RadioButton();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrimEkle = new System.Windows.Forms.Button();
            this.btnPrimleriGoster = new System.Windows.Forms.Button();
            this.btnPersoneleGorePrim = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // radioKisiyeOzel
            // 
            this.radioKisiyeOzel.AutoSize = true;
            this.radioKisiyeOzel.Location = new System.Drawing.Point(62, 30);
            this.radioKisiyeOzel.Name = "radioKisiyeOzel";
            this.radioKisiyeOzel.Size = new System.Drawing.Size(99, 17);
            this.radioKisiyeOzel.TabIndex = 0;
            this.radioKisiyeOzel.TabStop = true;
            this.radioKisiyeOzel.Text = "Kişiye Özel Prim";
            this.radioKisiyeOzel.UseVisualStyleBackColor = true;
            // 
            // radioTumPersoneller
            // 
            this.radioTumPersoneller.AutoSize = true;
            this.radioTumPersoneller.Location = new System.Drawing.Point(446, 34);
            this.radioTumPersoneller.Name = "radioTumPersoneller";
            this.radioTumPersoneller.Size = new System.Drawing.Size(144, 17);
            this.radioTumPersoneller.TabIndex = 1;
            this.radioTumPersoneller.TabStop = true;
            this.radioTumPersoneller.Text = "Tüm Personeller İçin Prim";
            this.radioTumPersoneller.UseVisualStyleBackColor = true;
            this.radioTumPersoneller.CheckedChanged += new System.EventHandler(this.radioTumPersoneller_CheckedChanged);
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(135, 61);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(217, 20);
            this.txtPersonelID.TabIndex = 2;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(135, 99);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(217, 20);
            this.txtPersonelAdSoyad.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(233, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(77, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Dönem:";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(254, 125);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(98, 21);
            this.comboYil.TabIndex = 16;
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
            this.comboAy.Location = new System.Drawing.Point(135, 125);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(92, 21);
            this.comboAy.TabIndex = 15;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(509, 65);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(320, 20);
            this.txtPrimTutari.TabIndex = 19;
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(509, 91);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(320, 48);
            this.txtAciklama.TabIndex = 20;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dataGridView1.Location = new System.Drawing.Point(0, 248);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(854, 263);
            this.dataGridView1.TabIndex = 21;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 102);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "Personel Ad Soyad:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 64);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "PersonelID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(443, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Prim Tutarı:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(450, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Açıklama:";
            // 
            // btnPrimEkle
            // 
            this.btnPrimEkle.FlatAppearance.BorderSize = 0;
            this.btnPrimEkle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimEkle.ImageKey = "Plus-Symbol-Vector-PNG-HD-Image.png";
            this.btnPrimEkle.ImageList = this.ımageList1;
            this.btnPrimEkle.Location = new System.Drawing.Point(327, 173);
            this.btnPrimEkle.Name = "btnPrimEkle";
            this.btnPrimEkle.Size = new System.Drawing.Size(97, 69);
            this.btnPrimEkle.TabIndex = 26;
            this.btnPrimEkle.Text = "Prim Ekle";
            this.btnPrimEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimEkle.UseVisualStyleBackColor = true;
            this.btnPrimEkle.Click += new System.EventHandler(this.btnPrimEkle_Click);
            // 
            // btnPrimleriGoster
            // 
            this.btnPrimleriGoster.FlatAppearance.BorderSize = 0;
            this.btnPrimleriGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimleriGoster.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimleriGoster.ImageKey = "index.png";
            this.btnPrimleriGoster.ImageList = this.ımageList1;
            this.btnPrimleriGoster.Location = new System.Drawing.Point(430, 173);
            this.btnPrimleriGoster.Name = "btnPrimleriGoster";
            this.btnPrimleriGoster.Size = new System.Drawing.Size(97, 69);
            this.btnPrimleriGoster.TabIndex = 27;
            this.btnPrimleriGoster.Text = "Primleri Göster";
            this.btnPrimleriGoster.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimleriGoster.UseVisualStyleBackColor = true;
            this.btnPrimleriGoster.Click += new System.EventHandler(this.btnPrimleriGoster_Click);
            // 
            // btnPersoneleGorePrim
            // 
            this.btnPersoneleGorePrim.FlatAppearance.BorderSize = 0;
            this.btnPersoneleGorePrim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPersoneleGorePrim.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPersoneleGorePrim.ImageKey = "png-transparent-computer-icons-register-button-miscellaneous-text-logo-thumbnail." +
    "png";
            this.btnPersoneleGorePrim.ImageList = this.ımageList1;
            this.btnPersoneleGorePrim.Location = new System.Drawing.Point(533, 173);
            this.btnPersoneleGorePrim.Name = "btnPersoneleGorePrim";
            this.btnPersoneleGorePrim.Size = new System.Drawing.Size(97, 69);
            this.btnPersoneleGorePrim.TabIndex = 28;
            this.btnPersoneleGorePrim.Text = "Personel Primleri";
            this.btnPersoneleGorePrim.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPersoneleGorePrim.UseVisualStyleBackColor = true;
            this.btnPersoneleGorePrim.Click += new System.EventHandler(this.btnPersoneleGorePrim_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "enephoto (3).png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(745, 173);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(97, 69);
            this.btnCikis.TabIndex = 30;
            this.btnCikis.Text = "Çıkış";
            this.btnCikis.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnCikis.UseVisualStyleBackColor = true;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.FlatAppearance.BorderSize = 0;
            this.btnTemizle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTemizle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTemizle.ImageKey = "enephoto (2).png";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(642, 173);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(97, 69);
            this.btnTemizle.TabIndex = 29;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // ımageList1
            // 
            this.ımageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ımageList1.ImageStream")));
            this.ımageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.ımageList1.Images.SetKeyName(0, "2.png");
            this.ımageList1.Images.SetKeyName(1, "452-4520057_top-icon-user-personal-contact-icon-png-transparent.png");
            this.ımageList1.Images.SetKeyName(2, "1000_F_245575617_xQWlAV1FFLKl00hL7xjHPESjJOePW7CK.jpg");
            this.ımageList1.Images.SetKeyName(3, "3152161-200.png");
            this.ımageList1.Images.SetKeyName(4, "6372226.png");
            this.ımageList1.Images.SetKeyName(5, "enephoto (1).jpg");
            this.ımageList1.Images.SetKeyName(6, "enephoto (1).png");
            this.ımageList1.Images.SetKeyName(7, "enephoto (2).png");
            this.ımageList1.Images.SetKeyName(8, "enephoto (3).png");
            this.ımageList1.Images.SetKeyName(9, "images.png");
            this.ımageList1.Images.SetKeyName(10, "index.png");
            this.ımageList1.Images.SetKeyName(11, "png-clipart-salary-computer-icons-wage-payment-profit-others-miscellaneous-hand-t" +
        "humbnail.png");
            this.ımageList1.Images.SetKeyName(12, "png-transparent-computer-icons-register-button-miscellaneous-text-logo-thumbnail." +
        "png");
            this.ımageList1.Images.SetKeyName(13, "png-transparent-computer-icons-user-avatar-management-add-icon-smiley-business-ad" +
        "d-icon.png");
            this.ımageList1.Images.SetKeyName(14, "pngtree-vector-office-icon-png-image_894932.jpg");
            this.ımageList1.Images.SetKeyName(15, "unnamed.jpg");
            this.ımageList1.Images.SetKeyName(16, "unnamed.png");
            this.ımageList1.Images.SetKeyName(17, "pngtree-menu-vector-icon-png-image_355811.jpg");
            this.ımageList1.Images.SetKeyName(18, "588a6507d06f6719692a2d15.png");
            this.ımageList1.Images.SetKeyName(19, "Plus-Symbol-Vector-PNG-HD-Image.png");
            // 
            // frmPrimEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 511);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnPersoneleGorePrim);
            this.Controls.Add(this.btnPrimleriGoster);
            this.Controls.Add(this.btnPrimEkle);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.radioTumPersoneller);
            this.Controls.Add(this.radioKisiyeOzel);
            this.Name = "frmPrimEkle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prim Sayfası";
            this.Load += new System.EventHandler(this.frmPrimler_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton radioKisiyeOzel;
        private System.Windows.Forms.RadioButton radioTumPersoneller;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrimEkle;
        private System.Windows.Forms.Button btnPrimleriGoster;
        private System.Windows.Forms.Button btnPersoneleGorePrim;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}