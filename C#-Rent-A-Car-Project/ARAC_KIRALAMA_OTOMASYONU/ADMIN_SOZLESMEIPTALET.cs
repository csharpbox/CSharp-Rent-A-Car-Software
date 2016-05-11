using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using MetroFramework;
using MetroFramework.Forms;


namespace ARAC_KIRALAMA_OTOMASYONU
{
    public partial class ADMIN_SOZLESMEIPTALET : MetroForm
    {
        OleDbConnection cnn;
        public ADMIN_SOZLESMEIPTALET()
        {
            InitializeComponent();
        }
        void SOZLESMEBAGLANTI()
        {
            string baglan = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=database.mdb";
            cnn = new OleDbConnection(baglan);
            cnn.Open();
        }
        void SOZLESMESILME()
        {
            OleDbCommand Cmd_Sil = new OleDbCommand("Delete From TBL_Database Where Tc_Kimlik_No='" + SOZLESME_IPTAL_ETME_BOLUMU_TEXTBOX_TCNO.Text + "'", cnn);
            Cmd_Sil.ExecuteNonQuery();
        }
        private void BTN_SOZLESMEIPTALETMEBOLUMU_Click(object sender, EventArgs e)
        {
            SOZLESMESILME();
        }

        private void ADMIN_SOZLESMEIPTALET_Load(object sender, EventArgs e)
        {
            SOZLESMEBAGLANTI();
        }
    }
}
