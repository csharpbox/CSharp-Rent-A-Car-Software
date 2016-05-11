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
    public partial class ADMIN_PANELI : MetroForm
    {
        public ADMIN_PANELI()
        {
            InitializeComponent();
        }
        void PROGRAMIKAPAT()
        {
            Application.Exit();
        }
        void HAKKIMIZDA()
        {
            ADMIN_HAKKIMIZDA hakimizda = new ADMIN_HAKKIMIZDA();
            hakimizda.Show();
        }
        void SOZLEMEYAP()
        {
            ADMIN_SOZLESMEYAP sozlesmeyap = new ADMIN_SOZLESMEYAP();
            sozlesmeyap.Show();
        }
        void SOZLEMEIPTALET()
        {
            ADMIN_SOZLESMEIPTALET sozlesmeiptalet = new ADMIN_SOZLESMEIPTALET();
            sozlesmeiptalet.Show();
        }
        void ARACKIRALAMAVERITABANI()
        {
            ADMIN_ARACKIRALAMAVERITABANI arackiralamaveritabani = new ADMIN_ARACKIRALAMAVERITABANI();
            arackiralamaveritabani.Show();
        }
        void PROGRAMINASILKULLANIRIM()
        {
            ADMIN_PROGRAMINASILKULLANIRIM programinasilkullanirim = new ADMIN_PROGRAMINASILKULLANIRIM();
            programinasilkullanirim.Show();
        }
        void ADMINVERITABANI()
        {
            ADMIN_ADMINVERITABANI adminveritabani = new ADMIN_ADMINVERITABANI();
            adminveritabani.Show();
        }
        void ADMINYETKIKALDIRMA()
        {
            ADMIN_ADMINYETKIKALDIRMA adminyetkikaldirma = new ADMIN_ADMINYETKIKALDIRMA();
            adminyetkikaldirma.Show();
        }
        private void ADMIN_PANEL_BTN_CIKIS_Click(object sender, EventArgs e)
        {
            PROGRAMIKAPAT();
        }
        private void ADMIN_PANEL_BTN_SOZLESMEYAP_Click(object sender, EventArgs e)
        {
            SOZLEMEYAP();
        }
        private void ADMIN_PANEL_BTN_SOZLESMEIPTALET_Click(object sender, EventArgs e)
        {
            SOZLEMEIPTALET();
        }
        private void ADMIN_PANEL_BTN_ARACKIRALAMAVERITABANI_Click(object sender, EventArgs e)
        {
            ARACKIRALAMAVERITABANI();
        }
        private void ADMIN_PANEL_BTN_PROGRAMINASILKULLANIRIM_Click(object sender, EventArgs e)
        {
            PROGRAMINASILKULLANIRIM();
        }
        private void ADMIN_PANEL_BNT_HAKKIMIZDA_Click(object sender, EventArgs e)
        {
            HAKKIMIZDA();
        }
        private void ADMIN_PANEL_BTN_ADMINPANELI_Click(object sender, EventArgs e)
        {
            ADMINVERITABANI();
        }
        private void ADMIN_PANEL_BTN_ADMINYETKIKALDIRMA_Click(object sender, EventArgs e)
        {
            ADMINYETKIKALDIRMA();
        }

    }
}
