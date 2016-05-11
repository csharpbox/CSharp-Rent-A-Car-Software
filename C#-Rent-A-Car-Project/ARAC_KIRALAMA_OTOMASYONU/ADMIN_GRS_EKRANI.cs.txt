using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Forms;
using System.Data.OleDb;

namespace ARAC_KIRALAMA_OTOMASYONU
{
    public partial class ADMIN_GRS_EKRANI : MetroForm
    {
        public ADMIN_GRS_EKRANI()
        {
            InitializeComponent();
        }
        void PROGRAMIKAPAT()
        {
            Application.Exit();
        }
        void YENIKULLANICIEKLEME()
        {
            ADMIN_YENIKULLANICIEKLEME adminyenikullaniciekleme = new ADMIN_YENIKULLANICIEKLEME();
            adminyenikullaniciekleme.Show();
        }
        private void BTN_CIKIS_Click(object sender, EventArgs e)
        {
            PROGRAMIKAPAT();
        }
        OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=database.mdb");
        private void BTN_GRS_Click(object sender, EventArgs e)
        {
            try
            {
                baglanti.Open();
                OleDbCommand komut = new OleDbCommand("SELECT KullaniciAd,KullaniciSifre FROM TBL_Security WHERE KullaniciAd='" + ADMIN_GRS_EKRANI_TEXTBOX_AD.Text + "'and KullaniciSifre='" + ADMIN_GRS_EKRANI_TEXTBOX_SIFRE.Text + "'", baglanti);
                OleDbDataReader dr;
                dr = komut.ExecuteReader();
                if (dr.Read())
                {
                    ADMIN_PANELI adminpaneli = new ADMIN_PANELI();
                    adminpaneli.Show();
                    this.Visible = false;
                }
                else
                {
                    MessageBox.Show("!!! HATALI GİRİŞ !!!");
                    baglanti.Close();
                }
            }
            catch
            {
                MessageBox.Show("!!! LÜTFEN BÜTÜN ALANLARI DOĞRU BİR ŞEKİLDE GİRİNİZ. !!!");
            }
        }

        private void BTN_YENIKULLANICIEKLEME_Click(object sender, EventArgs e)
        {
            YENIKULLANICIEKLEME();
        }
    }
}
