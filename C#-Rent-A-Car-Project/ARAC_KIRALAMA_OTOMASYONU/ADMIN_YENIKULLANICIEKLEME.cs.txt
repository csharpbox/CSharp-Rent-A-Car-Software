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
    public partial class ADMIN_YENIKULLANICIEKLEME : MetroForm
    {
        OleDbConnection cnn;
        OleDbCommand CMD_YENIKULLANICIEKLE;
        public ADMIN_YENIKULLANICIEKLEME()
        {
            InitializeComponent();
        }
        void YENIKULLANICIEKLEME_VERITABANIBAGLANTISI()
        {
            string baglan = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=database.mdb";
            cnn = new OleDbConnection(baglan);
            cnn.Open();
        }
        void YENIKULLANICIEKLE()
        {
            string ekle = "INSERT INTO TBL_Security(KullaniciAd,KullaniciSifre,TcNumarasi,AdSoyad,KanGrubu,DogumYeri,DogumTarihi,Memleket,EvTel,CepTel,EMail,Adres) VALUES ('" + TEXTBOX_YENIKULLANICIADI.Text + "','" + TEXTBOX_YENISIFRE.Text + "','"+ YENIKULLANICIEKLEME_TEXTBOX_TCNO.Text +"','"+ YENIKULLANICIEKLEME_TEXTBOX_ADSOYAD.Text +"','"+ YENIKULLANICIEKLEME_COMBOBOX_KANGRUBU.Text +"','"+YENIKULLANICIEKLEME_TEXTBOX_DOGUMYERI.Text+"','"+YENIKULLANICIEKLEME_DATETIME_DOGUMTARIHI.Text+"','"+YENIKULLANICIEKLEME_TEXTBOX_MEMLEKET.Text+"','"+YENIKULLANICIEKLEME_TEXTBOX_EVTEL.Text+"','"+YENIKULLANICIEKLEME_TEXTBOX_CEPTEL.Text+"','"+YENIKULLANICIEKLEME_TEXTBOX_EMAIL.Text+"','"+YENIKULLANICIEKLEME_TEXTBOX_ADRES.Text+"')";
            CMD_YENIKULLANICIEKLE = new OleDbCommand(ekle, cnn);
            CMD_YENIKULLANICIEKLE.ExecuteNonQuery();
        }
        private void BTN_YENIKULLANICIEKLE_Click(object sender, EventArgs e)
        {
            YENIKULLANICIEKLEME_VERITABANIBAGLANTISI();
            YENIKULLANICIEKLE();
        }
    }
}
