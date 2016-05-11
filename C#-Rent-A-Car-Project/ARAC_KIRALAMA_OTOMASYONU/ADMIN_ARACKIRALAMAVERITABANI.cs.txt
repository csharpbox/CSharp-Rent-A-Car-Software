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
    public partial class ADMIN_ARACKIRALAMAVERITABANI : MetroForm
    {
        OleDbConnection cnn;
        public ADMIN_ARACKIRALAMAVERITABANI()
        {
            InitializeComponent();
        }
        void ARACKIRALAMAVERITABANIBAGLANTI()
        {
            string baglan = "Provider=Microsoft.JET.OLEDB.4.0;Data Source=database.mdb";
            cnn = new OleDbConnection(baglan);
            cnn.Open();
        }
        void ARACKIRALAMAVERITABANI()
        {
            string sorgu = ("Select * From TBL_Database");
            OleDbDataAdapter adp = new OleDbDataAdapter(sorgu, cnn);
            DataSet ds = new DataSet();
            adp.Fill(ds, "TBL_Database");
            METROGRID_ARACKIRALAMAVERITABANI.DataSource = ds.Tables["TBL_Database"];
        }
        private void ADMIN_ARACKIRALAMAVERITABANI_Load(object sender, EventArgs e)
        {
            ARACKIRALAMAVERITABANIBAGLANTI();
            ARACKIRALAMAVERITABANI();
        }
    }
}
