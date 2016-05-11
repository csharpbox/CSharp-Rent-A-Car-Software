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
    public partial class ADMIN_ADMINYETKIKALDIRMA : MetroForm
    {
        OleDbConnection cnn;
        public ADMIN_ADMINYETKIKALDIRMA()
        {
            InitializeComponent();
        }
        void ADMINYETKIKALDIRMABAGLANTI()
        {
            string baglan = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=database.mdb";
            cnn = new OleDbConnection(baglan);
            cnn.Open();
        }
        void ADMINYETKIKALDIRMA()
        {
            OleDbCommand Cmd_Sil1 = new OleDbCommand("Delete From TBL_Security Where KullaniciAd='" + ADMIN_YETKI_KALDIRMA_TEXTBOX_KULLANICIADI.Text + "'", cnn);
            Cmd_Sil1.ExecuteNonQuery();
            OleDbCommand Cmd_Sil2 = new OleDbCommand("Delete From TBL_Security Where KullaniciSifre='" + ADMIN_YETKI_KALDIRMA_TEXTBOX_KULLANICISIFRE.Text + "'", cnn);
            Cmd_Sil2.ExecuteNonQuery();
        }
        private void ADMIN_ADMINYETKIKALDIRMA_Load(object sender, EventArgs e)
        {
            ADMINYETKIKALDIRMABAGLANTI();
        }
        private void BTN_ADMINYETKISINIKALDIR_Click(object sender, EventArgs e)
        {
            ADMINYETKIKALDIRMA();
        }
    }
}
