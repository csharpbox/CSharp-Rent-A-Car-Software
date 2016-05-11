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

namespace ARAC_KIRALAMA_OTOMASYONU
{
    public partial class GRS_EKRANI : MetroForm
    {
        public GRS_EKRANI()
        {
            InitializeComponent();
        }
        void ACILISEFEKTI()
        {
            if (METROPROGRESSBAR.Value < 100)
            {
                METROPROGRESSBAR.Value = METROPROGRESSBAR.Value + 2;
            }
            else
            {
                PROGRESSBAR_ZAMAN.Enabled = false;
                this.Visible = false;
                ADMIN_GRS_EKRANI admingirisekrani = new ADMIN_GRS_EKRANI();
                admingirisekrani.Show();
            }
        }
        private void PROGRESSBAR_ZAMAN_Tick(object sender, EventArgs e)
        {
            ACILISEFEKTI();
        }
    }
}
