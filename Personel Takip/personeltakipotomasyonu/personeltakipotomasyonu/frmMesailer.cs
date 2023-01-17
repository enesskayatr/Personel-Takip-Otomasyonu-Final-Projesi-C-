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
    public partial class frmMesailer : Form
    {
        public frmMesailer()
        {
            InitializeComponent();
        }

        private void frmMesailer_Load(object sender, EventArgs e)
        {
            Veritabanı.Listele_Ara(dataGridView1,"select * from Mesailer");
            int yil = DateTime.Now.Year;
            for (int i = yil; i >= yil - 5; i--)
            {
                comboYil.Items.Add(i);
            }
        }

        private void txtPersonelID_TextChanged(object sender, EventArgs e)
        {
            Primler.PersonelAdSoyadGetir(txtPersonelID, txtAdiSoyadi);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataGridView1.CurrentRow.Cells["OdenmeDurumu"].Value.ToString()=="Ödenmedi")
            {
            txtMesaiID.Text = dataGridView1.CurrentRow.Cells["MesaiID"].Value.ToString();
            txtPersonelID.Text = dataGridView1.CurrentRow.Cells["PersonelID"].Value.ToString();
            txtMesaiSaatiUcreti.Text = dataGridView1.CurrentRow.Cells["MesaiSaatiUcreti"].Value.ToString();
            txtTutar.Text= dataGridView1.CurrentRow.Cells["Tutar"].Value.ToString();
            txtAciklama.Text = dataGridView1.CurrentRow.Cells["Aciklama"].Value.ToString();
            string baslangic = dataGridView1.CurrentRow.Cells["BaslangicSaati"].Value.ToString();
            string bitis = dataGridView1.CurrentRow.Cells["BitisSaati"].Value.ToString();
            string donem = dataGridView1.CurrentRow.Cells["Donem"].Value.ToString();
            dateTimeBaslangic.Text = baslangic.Substring(0, 10);
            maskedtxtBaslangic.Text = baslangic.Substring(11);
            dateTimeBitis.Text=bitis.Substring(0, 10);
            maskedtxtBitis.Text=bitis.Substring(11);
            int say=donem.IndexOf("/");
            comboAy.Text=donem.Substring(0, say);
            comboYil.Text=donem.Substring(say+1);
            }
            

  

        }

        private void txtMesaiSaatiUcreti_TextChanged(object sender, EventArgs e)
        {
            try
            {
                string baslangic =dateTimeBaslangic.Text + " " + maskedtxtBaslangic.Text;
                string bitis = dateTimeBitis.Text + " " + maskedtxtBitis.Text;
                TimeSpan saatfarki = DateTime.Parse(bitis) - DateTime.Parse(baslangic);
                double MSaatUcreti = double.Parse(txtMesaiSaatiUcreti.Text);
                double tutar = saatfarki.TotalHours * MSaatUcreti;
                txtTutar.Text = tutar.ToString("0.00");
            }
            catch 
            {

               
            }
        }

        

        private void btnPersonelMesaileri_Click(object sender, EventArgs e)
        {
            frmPersonelMesaileri frm=new frmPersonelMesaileri();
            frm.ShowDialog();
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            foreach (Control item in Controls)
            {
                if (item is TextBox)
                {
                    item.Text = "";
                }
                if (item is ComboBox)
                {
                    item.Text = "";
                }
                if (item is MaskedTextBox)
                {
                    item.Text = "";
                }
            }
            dateTimeBaslangic.Value=DateTime.Now;
            dateTimeBitis.Value=DateTime.Now;  
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (txtAdiSoyadi.Text != string.Empty)
            {


                Mesailer m = new Mesailer();
                Personeller p = new Personeller();
                Kullanicilar k = new Kullanicilar();
                m.MesaiID = int.Parse(txtMesaiID.Text);
                p.PERSONELID = int.Parse(txtPersonelID.Text);
                m.Islem = m.MesaiID + " nolu mesai kaydı silindi";
                m.Aciklama = "Mesai Silme";
                if (MessageBox.Show("Bu kayıt silinsin mi?", "Mesai Silme Uyarısı", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    string sql = "delete from Mesailer where MesaiID='" + m.MesaiID + "'";
                    SqlCommand komut = new SqlCommand();
                    Veritabanı.ESG(komut, sql);
                    MessageBox.Show(m.MesaiID + " nolu mesai kaydı silindi.", "Mesai Silme", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    MesaiHareketleriEkle(k, m, p);
                    btnTemizle.PerformClick();
                    Veritabanı.Listele_Ara(dataGridView1, "select * from Mesailer");
                }
            }
            else
            {
                MessageBox.Show("Hatalı işlem seçimi");
            }
        }

        private void btnTumMesaileriOde_Click(object sender, EventArgs e)
        {
            if (txtAdiSoyadi.Text != string.Empty)
            {


                Mesailer m = new Mesailer();
                Kullanicilar k = new Kullanicilar();
                Personeller p = new Personeller();
                m.OdenmeDurumu = "Ödendi";
                string sql = "update Mesailer set OdenmeDurumu='" + m.OdenmeDurumu + "' where OdenmeDurumu='Ödenmedi'";
                SqlCommand komut = new SqlCommand();
                Veritabanı.ESG(komut, sql);
                MessageBox.Show("Ödenmeyen tüm mesailer ödendi.", "Mesai Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);


                for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
                {
                    if (dataGridView1.Rows[i].Cells["OdenmeDurumu"].Value.ToString() == "Ödenmedi")
                    {
                        m.MesaiID = int.Parse(dataGridView1.Rows[i].Cells["MesaiID"].Value.ToString());
                        p.PERSONELID = int.Parse(dataGridView1.Rows[i].Cells["PersonelID"].Value.ToString());
                        m.Islem = m.MesaiID + " nolu mesai ücreti ödendi";
                        m.Aciklama = "Tüm Mesaileri Ödeme";
                        MesaiHareketleriEkle(k, m, p);
                    }
                }
                btnTemizle.PerformClick();
                Veritabanı.Listele_Ara(dataGridView1, "select * from Mesailer");
            }
            else
            {
                MessageBox.Show("Hatalı işlem seçimi");
            }
        }
        void MesaiHareketleriEkle(Kullanicilar k,Mesailer m,Personeller p)
        {
            k.KullaniciID = Kullanicilar.kid;
            string sql="insert into MesaiHareketleri values('"+k.KullaniciID+"','"+p.PERSONELID+"','"+m.MesaiID+"','"+m.Islem+"','"+m.Aciklama+"',@Tarih)";
            SqlCommand komut = new SqlCommand();
            komut.Parameters.Add("@Tarih",SqlDbType.Date).Value=DateTime.Now;
            Veritabanı.ESG(komut,sql);
        }
        private void btnMesaiOde_Click(object sender, EventArgs e)
        {
            if (txtAdiSoyadi.Text != string.Empty)
            {


                Mesailer m = new Mesailer();
                Kullanicilar k = new Kullanicilar();
                Personeller p = new Personeller();
                p.PERSONELID = int.Parse(txtPersonelID.Text);

                m.OdenmeDurumu = "Ödendi";
                m.MesaiID = int.Parse(txtMesaiID.Text);
                m.Islem = m.MesaiID + " nolu nolu mesai için ödeme yapıldı.";
                m.Aciklama = "Mesai ödeme";
                string sql = "update Mesailer set OdenmeDurumu='" + m.OdenmeDurumu + "' where MesaiID='" + m.MesaiID + "'";
                SqlCommand komut = new SqlCommand();
                Veritabanı.ESG(komut, sql);
                MessageBox.Show(m.MesaiID + " nolu mesai ücreti ödendi.", "Mesai Ödeme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MesaiHareketleriEkle(k, m, p);
                btnTemizle.PerformClick();
                Veritabanı.Listele_Ara(dataGridView1, "select * from Mesailer");
            }
            else
            {
                MessageBox.Show("Hatalı işlem seçimi");
            }

        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (txtAdiSoyadi.Text != string.Empty)
            {


                Mesailer m = new Mesailer();
                Personeller p = new Personeller();
                Kullanicilar k = new Kullanicilar();
                p.PERSONELID = int.Parse(txtPersonelID.Text);
                m.MesaiID = int.Parse(txtMesaiID.Text);
                m.Baslangic_Saati = dateTimeBaslangic.Text + " " + maskedtxtBaslangic.Text;
                m.Bitis_Saati = dateTimeBitis.Text + " " + maskedtxtBitis.Text;
                m.MesaiSaatUcreti = Decimal.Parse(txtMesaiSaatiUcreti.Text);
                m.Tutar = decimal.Parse(txtTutar.Text);
                m.Donem = comboAy.Text + "/" + comboYil.Text;
                m.Aciklama = txtAciklama.Text;
                string sql = "update Mesailer set PersonelID='" + p.PERSONELID + "',baslangicsaati='" + m.Baslangic_Saati + "',bitissaati='" + m.Bitis_Saati + "'," +
                    "mesaisaatiucreti=@MSaatiUcreti,Tutar=@Tutar,donem='" + m.Donem + "',aciklama='" + m.Aciklama + "' where mesaiID='" + m.MesaiID + "'";
                SqlCommand komut = new SqlCommand();
                komut.Parameters.Add("MSaatiUcreti", SqlDbType.Decimal).Value = m.MesaiSaatUcreti;
                komut.Parameters.Add("Tutar", SqlDbType.Decimal).Value = m.Tutar;
                Veritabanı.ESG(komut, sql);
                MessageBox.Show(m.MesaiID + " nolu mesai kaydı güncellendi.", "Mesai Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                m.Islem = m.MesaiID + " nolu mesaiID için güncelleme yapıldı.";
                m.Aciklama = "Mesai Güncelleme";
                MesaiHareketleriEkle(k, m, p);
                btnTemizle.PerformClick();
                Veritabanı.Listele_Ara(dataGridView1, "select * from Mesailer");
            }
            else
            {
                MessageBox.Show("Hatalı işlem seçimi");
            }

        }
    }
}
