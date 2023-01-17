using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace personeltakipotomasyonu
{
    public partial class AnaSayfa : Form
    {
        public AnaSayfa()
        {
            InitializeComponent();
        }
        void FormGetir(Form form,Panel panel)
        {
            panel.Controls.Clear();
            form.TopLevel = false;
            panel.Controls.Add(form);
            form.Dock=DockStyle.Fill;
            form.BringToFront();
            form.Show();
            form.FormBorderStyle= FormBorderStyle.None;
        }
        private void btnDepartmanlar_Click(object sender, EventArgs e)
        {
            frmDepartmanlar frm=new frmDepartmanlar();
            FormGetir(frm, panelFormlar);


        }

        private void btnPersonelEkle_Click(object sender, EventArgs e)
        {
            frmPersonelEkle frm=new frmPersonelEkle();
            frm.ShowDialog();
        }

        private void btnPersonelListele_Click(object sender, EventArgs e)
        {
            frmPersonelListele frm=new frmPersonelListele();
            
            FormGetir(frm, panelFormlar);
        }

        private void AnaSayfa_Load(object sender, EventArgs e)
        {
            frmKullanici k=new frmKullanici();
            k.ShowDialog();
            panelIslemler.Width = 80;
        }

        private void btnMaasZamlari_Click(object sender, EventArgs e)
        {
            frmYapilanZamlar frm=new frmYapilanZamlar();
            frm.ShowDialog();
        }

        private void btnPrim_Click(object sender, EventArgs e)
        {
            frmPrimEkle frm=new frmPrimEkle();
            FormGetir(frm, panelFormlar);
        }

        private void btnMesaiEkle_Click(object sender, EventArgs e)
        {
            frmMesaiEkle frm=new frmMesaiEkle();
            frm.ShowDialog();

        }

        private void btnMesailer_Click(object sender, EventArgs e)
        {
            frmMesailer frm=new frmMesailer();
            FormGetir(frm, panelFormlar);
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (panelIslemler.Width==170)
            {
                panelIslemler.Width = 80;
            }
            else if (panelIslemler.Width==80)
            {
                panelIslemler.Width = 170;
            }
            
        }
    }
}
