using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MetroFramework;
using System.Data.OleDb;
using MetroFramework.Forms;

namespace ARAC_KIRALAMA_OTOMASYONU
{
    public partial class ADMIN_SOZLESMEYAP : MetroForm
    {
        OleDbConnection cnn;
        OleDbCommand CMD_EKLE;
        public ADMIN_SOZLESMEYAP()
        {
            InitializeComponent();
        }
        void SOZLESMEBAGLANTI()
        {
            string baglan = "Provider=Microsoft.Jet.Oledb.4.0;Data Source=database.mdb";
            cnn = new OleDbConnection(baglan);
            cnn.Open();
        }
        void SOZLESMEYAP()
        {
            string ekle = "INSERT INTO TBL_Database(Tc_Kimlik_No,Ad_Soyad,Cinsiyet,Dogum_Tarihi,Dogum_Yeri,Ev_Tel,Cep_Tel,Email,Adres,Ehliyet_No,Ehliyet_Tarihi,Ehliyet_Verilen_Yer,Surucu_Ad_Soyad,Kefil_Ad_Soyad,Kefil_Adres,Kefil_Tel,Kefil_Cep,Plaka,Marka,Tip,Model,Renk,Gunluk,Aylik,Cikis_Zamani,Donus_Zamani,Ek_Tutar,Toplam)Values('" + TEXTBOX_TCNO.Text + "','" + TEXTBOX_ADSOYAD.Text + "','" + COMBOBOX_CINSIYET.Text + "','" + DATETIME_DOGUMTARIHI.Text + "','" + TEXTBOX_DOGUMYERI.Text + "','" + TEXTBOX_EVTEL.Text + "','" + TEXTBOX_CEPTEL.Text + "','" + TEXTBOX_EMAIL.Text + "','" + TEXTBOX_ADRES.Text + "','" + TEXTBOX_EHLIYETNO.Text + "','" + DATETIME_EHLIYETTARIHI.Text + "','" + TEXTBOX_EHLIYETVERILENYER.Text + "','" + TEXTBOX_SURUCUADSOYAD.Text + "','" + TEXTBOX_KEFILADSOYAD.Text + "','" + TEXT_KEFILADRES.Text +"','" + TEXTBOX_KEFILTEL.Text + "','" + TEXTBOX_KEFILCEP.Text + "','" + TEXT_PLAKA.Text + "','" + COMBOBOX_MARKA.Text + "','" + COMBOBOX_TIP.Text + "','" + TEXTBOX_MODEL.Text + "','" + COMBOBOX_RENK.Text + "','" + TEXTBOX_GUNLUK.Text + "','" + TEXTBOX_AYLIK.Text + "','" + DATETIME_CIKISTARIHI.Text + "','" + DATETIME_DONUSTARIHI.Text + "','" + TEXTBOX_EKTUTAR.Text + "','" + TEXTBOX_TOPLAM.Text + "')";
            CMD_EKLE = new OleDbCommand(ekle, cnn);
            CMD_EKLE.ExecuteNonQuery();
        }
        void PROGRAMIKAPAT()
        {
            Application.Exit();
        }
        private void SOZLESMEYAP_BTN_PROGRAMIKAPAT_Click(object sender, EventArgs e)
        {
            PROGRAMIKAPAT();
        }
        void ARACKIRALAMAVERITABANINIGOSTER()
        {
            ADMIN_ARACKIRALAMAVERITABANI arackiralamaveritabani = new ADMIN_ARACKIRALAMAVERITABANI();
            arackiralamaveritabani.Show();
        }
        private void SOZLESMEYAP_BTN_ARACKIRALAMAVERITABANINIGOSTER_Click(object sender, EventArgs e)
        {
            ARACKIRALAMAVERITABANINIGOSTER();
        }
       
        private void SOZLESMEYAP_BTN_SOZLESMEYAP_Click(object sender, EventArgs e)
        {
            SOZLESMEYAP();
        }

        private void ADMIN_SOZLESMEYAP_Load(object sender, EventArgs e)
        {
            SOZLESMEBAGLANTI();
        }
    }
}
