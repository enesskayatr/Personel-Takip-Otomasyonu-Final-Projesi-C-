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
    public partial class frmMesaiEkle : Form
    {
        public frmMesaiEkle()
        {
            InitializeComponent();
        }

        private void frmMesaiEkle_Load(object sender, EventArgs e)
        {
            int yil=DateTime.Now.Year;
            for (int i = yil; i >=yil-5; i--)
            {
                comboYil.Items.Add(i);
            }
            YapilanZamlar.ComboyaPersonelGetir(comboPersonelAdsoyad);

        }

        Label lbl;
        private void comboPersonelAdsoyad_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl=new Label();
            YapilanZamlar.ComboSecilirsePersonelIDGetir(comboPersonelAdsoyad,lbl);
            MessageBox.Show(lbl.Text);
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            if (txtMesaiSaatiUcreti.Text != string.Empty)
            {


                Kullanicilar k = new Kullanicilar();
                Personeller p = new Personeller();
                Mesailer m = new Mesailer();
                k.KullaniciID = Kullanicilar.kid;
                p.PERSONELID = int.Parse(lbl.Text);
                m.Baslangic_Saati = dateTimeBaslangic.Text + " " + maskedtxtBaslangic.Text;
                m.Bitis_Saati = dateTimeBitis.Text + " " + maskedtxtBitis.Text;
                m.MesaiSaatUcreti = decimal.Parse(txtMesaiSaatiUcreti.Text);
                m.Tutar = decimal.Parse(txtTutar.Text);
                m.Donem = comboAy.Text + "/" + comboYil.Text;
                m.Aciklama = txtAciklama.Text;
                m.Tarih = DateTime.Now;
                string sql = "insert into Mesailer(KullaniciID,PersonelID,BaslangicSaati,BitisSaati,MesaiSaatiUcreti,Tutar,Donem,Aciklama,Tarih) " +
                    "values('" + k.KullaniciID + "','" + p.PERSONELID + "','" + m.Baslangic_Saati + "','" + m.Bitis_Saati + "',@MSaatUcreti,@Tutar,'" + m.Donem + "','" + m.Aciklama + "',@Tarih)";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("@MSaatUcreti", SqlDbType.Decimal).Value = m.MesaiSaatUcreti;
                komut.Parameters.Add("@Tutar", SqlDbType.Decimal).Value = m.Tutar;
                komut.Parameters.Add("Tarih", SqlDbType.Date).Value = m.Tarih;
                Veritabanı.ESG(komut, sql);
                MessageBox.Show("Mesai bilgileri eklendi.", "Mesailer", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Hatalı işlem seçimi");
            }
        }

        private void txtTutar_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled=true;
        }

        private void txtMesaiSaatiUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic = dateTimeBaslangic.Text + " " + maskedtxtBaslangic.Text;
                string bitis = dateTimeBitis.Text + " " + maskedtxtBitis.Text;
                TimeSpan saatfarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double MSaatUcreti=double.Parse(txtMesaiSaatiUcreti.Text);
                double tutar = saatfarki.TotalHours * MSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch 
            {

            
            }
        }
    }
}
