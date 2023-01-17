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

namespace personeltakipotomasyonu
{
    public partial class frmSifremiUnuttum : Form
    {
        public frmSifremiUnuttum()
        {
            InitializeComponent();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }
        void temizle()
        {
            comboSoru.Text = " ";
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = " ";
                }
            }
        }
        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            Kullanicilar k = new Kullanicilar();
            k.KullaniciID =int.Parse(txtKullaniciID.Text);
            k.KullaniciAdi = txtKullaniciAdi.Text;
            k.Sifre = txtSifre.Text;
            k.AdiSoyadi = txtAdiSoyadi.Text;
            k.Soru = comboSoru.Text;
            k.Cevap = txtCevap.Text;
            k.Aciklama = txtAciklama.Text;
            k.Tarih = DateTime.Now;

            if (txtSifre.Text==txtSifreTekrar.Text)
            {
            string sql = "update kullanicilar set kullaniciAdi='"+k.KullaniciAdi+"',Sifre='"+k.Sifre+"',AdiSoyadi='"+k.AdiSoyadi+ "',Soru='"+k.Soru+ "',Cevap='"+k.Cevap+ "',Tarih=@Tarih,Aciklama='" + k.Aciklama+"' where kullaniciID='" + k.KullaniciID+"'";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Tarih", SqlDbType.Date).Value = k.Tarih;

            Veritabanı.ESG(komut, sql);
            MessageBox.Show("Kullanıcı bilgileri güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            temizle();
            }
            else
            {
                MessageBox.Show("Şifreler Uyuşmuyor.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            
        
        }
    }
}
