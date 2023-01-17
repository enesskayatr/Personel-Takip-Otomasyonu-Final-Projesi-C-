namespace personeltakipotomasyonu
{
    partial class frmPrimleriGoster
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrimleriGoster));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.txtPrimTutari = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboYil = new System.Windows.Forms.ComboBox();
            this.comboAy = new System.Windows.Forms.ComboBox();
            this.txtPersonelAdSoyad = new System.Windows.Forms.TextBox();
            this.txtPersonelID = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPrimID = new System.Windows.Forms.TextBox();
            this.btnTumPrimleriOde = new System.Windows.Forms.Button();
            this.btnPrimOde = new System.Windows.Forms.Button();
            this.btnPrimGuncelle = new System.Windows.Forms.Button();
            this.btnPrimSil = new System.Windows.Forms.Button();
            this.btnDonemDegistir = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.ımageList1 = new System.Windows.Forms.ImageList(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(797, 342);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(379, 411);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 40;
            this.label6.Text = "Açıklama:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(372, 385);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 39;
            this.label5.Text = "Prim Tutarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(48, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 38;
            this.label4.Text = "PersonelID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 426);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 37;
            this.label3.Text = "Personel Ad Soyad:";
            // 
            // txtAciklama
            // 
            this.txtAciklama.Location = new System.Drawing.Point(438, 411);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(328, 32);
            this.txtAciklama.TabIndex = 36;
            // 
            // txtPrimTutari
            // 
            this.txtPrimTutari.Location = new System.Drawing.Point(438, 382);
            this.txtPrimTutari.Name = "txtPrimTutari";
            this.txtPrimTutari.Size = new System.Drawing.Size(217, 20);
            this.txtPrimTutari.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(536, 358);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(12, 13);
            this.label2.TabIndex = 34;
            this.label2.Text = "/";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 363);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 33;
            this.label1.Text = "Dönem:";
            // 
            // comboYil
            // 
            this.comboYil.FormattingEnabled = true;
            this.comboYil.Location = new System.Drawing.Point(557, 355);
            this.comboYil.Name = "comboYil";
            this.comboYil.Size = new System.Drawing.Size(98, 21);
            this.comboYil.TabIndex = 32;
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
            this.comboAy.Location = new System.Drawing.Point(438, 355);
            this.comboAy.Name = "comboAy";
            this.comboAy.Size = new System.Drawing.Size(92, 21);
            this.comboAy.TabIndex = 31;
            // 
            // txtPersonelAdSoyad
            // 
            this.txtPersonelAdSoyad.Location = new System.Drawing.Point(124, 423);
            this.txtPersonelAdSoyad.Name = "txtPersonelAdSoyad";
            this.txtPersonelAdSoyad.Size = new System.Drawing.Size(217, 20);
            this.txtPersonelAdSoyad.TabIndex = 30;
            // 
            // txtPersonelID
            // 
            this.txtPersonelID.Location = new System.Drawing.Point(124, 385);
            this.txtPersonelID.Name = "txtPersonelID";
            this.txtPersonelID.Size = new System.Drawing.Size(217, 20);
            this.txtPersonelID.TabIndex = 29;
            this.txtPersonelID.TextChanged += new System.EventHandler(this.txtPersonelID_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(69, 354);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 13);
            this.label7.TabIndex = 42;
            this.label7.Text = "PrimID:";
            // 
            // txtPrimID
            // 
            this.txtPrimID.Location = new System.Drawing.Point(124, 351);
            this.txtPrimID.Name = "txtPrimID";
            this.txtPrimID.Size = new System.Drawing.Size(217, 20);
            this.txtPrimID.TabIndex = 41;
            // 
            // btnTumPrimleriOde
            // 
            this.btnTumPrimleriOde.FlatAppearance.BorderSize = 0;
            this.btnTumPrimleriOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTumPrimleriOde.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnTumPrimleriOde.ImageKey = "png-clipart-salary-computer-icons-wage-payment-profit-others-miscellaneous-hand-t" +
    "humbnail.png";
            this.btnTumPrimleriOde.ImageList = this.ımageList1;
            this.btnTumPrimleriOde.Location = new System.Drawing.Point(39, 457);
            this.btnTumPrimleriOde.Name = "btnTumPrimleriOde";
            this.btnTumPrimleriOde.Size = new System.Drawing.Size(105, 65);
            this.btnTumPrimleriOde.TabIndex = 43;
            this.btnTumPrimleriOde.Text = "Tüm Primleri Öde";
            this.btnTumPrimleriOde.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTumPrimleriOde.UseVisualStyleBackColor = true;
            this.btnTumPrimleriOde.Click += new System.EventHandler(this.btnTumPrimleriOde_Click);
            // 
            // btnPrimOde
            // 
            this.btnPrimOde.FlatAppearance.BorderSize = 0;
            this.btnPrimOde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimOde.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimOde.ImageKey = "png-clipart-salary-computer-icons-wage-payment-profit-others-miscellaneous-hand-t" +
    "humbnail.png";
            this.btnPrimOde.ImageList = this.ımageList1;
            this.btnPrimOde.Location = new System.Drawing.Point(161, 457);
            this.btnPrimOde.Name = "btnPrimOde";
            this.btnPrimOde.Size = new System.Drawing.Size(105, 65);
            this.btnPrimOde.TabIndex = 44;
            this.btnPrimOde.Text = "Prim Öde";
            this.btnPrimOde.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimOde.UseVisualStyleBackColor = true;
            this.btnPrimOde.Click += new System.EventHandler(this.btnPrimOde_Click);
            // 
            // btnPrimGuncelle
            // 
            this.btnPrimGuncelle.FlatAppearance.BorderSize = 0;
            this.btnPrimGuncelle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimGuncelle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimGuncelle.ImageKey = "index.png";
            this.btnPrimGuncelle.ImageList = this.ımageList1;
            this.btnPrimGuncelle.Location = new System.Drawing.Point(290, 457);
            this.btnPrimGuncelle.Name = "btnPrimGuncelle";
            this.btnPrimGuncelle.Size = new System.Drawing.Size(105, 65);
            this.btnPrimGuncelle.TabIndex = 45;
            this.btnPrimGuncelle.Text = "Prim Güncelle";
            this.btnPrimGuncelle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimGuncelle.UseVisualStyleBackColor = true;
            this.btnPrimGuncelle.Click += new System.EventHandler(this.btnPrimGuncelle_Click);
            // 
            // btnPrimSil
            // 
            this.btnPrimSil.FlatAppearance.BorderSize = 0;
            this.btnPrimSil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnPrimSil.ImageKey = "enephoto (2).png";
            this.btnPrimSil.ImageList = this.ımageList1;
            this.btnPrimSil.Location = new System.Drawing.Point(411, 457);
            this.btnPrimSil.Name = "btnPrimSil";
            this.btnPrimSil.Size = new System.Drawing.Size(105, 65);
            this.btnPrimSil.TabIndex = 46;
            this.btnPrimSil.Text = "Prim Sil";
            this.btnPrimSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPrimSil.UseVisualStyleBackColor = true;
            this.btnPrimSil.Click += new System.EventHandler(this.btnPrimSil_Click);
            // 
            // btnDonemDegistir
            // 
            this.btnDonemDegistir.Location = new System.Drawing.Point(661, 353);
            this.btnDonemDegistir.Name = "btnDonemDegistir";
            this.btnDonemDegistir.Size = new System.Drawing.Size(105, 48);
            this.btnDonemDegistir.TabIndex = 47;
            this.btnDonemDegistir.Text = "Dönem Değiştir";
            this.btnDonemDegistir.UseVisualStyleBackColor = true;
            this.btnDonemDegistir.Click += new System.EventHandler(this.btnDonemDegistir_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.FlatAppearance.BorderSize = 0;
            this.btnCikis.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCikis.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnCikis.ImageKey = "enephoto (3).png";
            this.btnCikis.ImageList = this.ımageList1;
            this.btnCikis.Location = new System.Drawing.Point(661, 457);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(97, 65);
            this.btnCikis.TabIndex = 49;
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
            this.btnTemizle.ImageKey = "enephoto (1).jpg";
            this.btnTemizle.ImageList = this.ımageList1;
            this.btnTemizle.Location = new System.Drawing.Point(539, 457);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(99, 65);
            this.btnTemizle.TabIndex = 48;
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
            // 
            // frmPrimleriGoster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 534);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnDonemDegistir);
            this.Controls.Add(this.btnPrimSil);
            this.Controls.Add(this.btnPrimGuncelle);
            this.Controls.Add(this.btnPrimOde);
            this.Controls.Add(this.btnTumPrimleriOde);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPrimID);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.txtPrimTutari);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboYil);
            this.Controls.Add(this.comboAy);
            this.Controls.Add(this.txtPersonelAdSoyad);
            this.Controls.Add(this.txtPersonelID);
            this.Controls.Add(this.dataGridView1);
            this.Name = "frmPrimleriGoster";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tüm Personellerin Primleri";
            this.Load += new System.EventHandler(this.frmPrimleriGoster_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.TextBox txtPrimTutari;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboYil;
        private System.Windows.Forms.ComboBox comboAy;
        private System.Windows.Forms.TextBox txtPersonelAdSoyad;
        private System.Windows.Forms.TextBox txtPersonelID;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPrimID;
        private System.Windows.Forms.Button btnTumPrimleriOde;
        private System.Windows.Forms.Button btnPrimOde;
        private System.Windows.Forms.Button btnPrimGuncelle;
        private System.Windows.Forms.Button btnPrimSil;
        private System.Windows.Forms.Button btnDonemDegistir;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.ImageList ımageList1;
    }
}