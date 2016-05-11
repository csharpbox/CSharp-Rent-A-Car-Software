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
    public partial class ADMIN_ADMINVERITABANI : MetroForm
    {
        OleDbConnection cnn;
        public ADMIN_ADMINVERITABANI()
        {
            InitializeComponent();
        }
        void ADMINVERITABNI_BAGLANTISI()
        {
            string baglan = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=database.mdb";
            cnn = new OleDbConnection(baglan);
            cnn.Open();
        }
        void ADMINVERITABANI()
        {
            string sorgu = ("Select * From TBL_Security");
            OleDbDataAdapter adp = new OleDbDataAdapter(sorgu, cnn);
            DataSet ds = new DataSet();
            adp.Fill(ds, "TBL_Security");
            METRODATAGRİD_ADMINVERITABANI.DataSource = ds.Tables["TBL_Security"];
        }
        private void ADMIN_ADMINVERITABANI_Load(object sender, EventArgs e)
        {
            ADMINVERITABNI_BAGLANTISI();
            ADMINVERITABANI();
        }
    }
}
