namespace ARAC_KIRALAMA_OTOMASYONU
{
    partial class GRS_EKRANI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GRS_EKRANI));
            this.ARAC_KIRALAMA_OTOMASYONU_PictureBox = new System.Windows.Forms.PictureBox();
            this.METROPROGRESSBAR = new MetroFramework.Controls.MetroProgressBar();
            this.PROGRESSBAR_ZAMAN = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ARAC_KIRALAMA_OTOMASYONU_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // ARAC_KIRALAMA_OTOMASYONU_PictureBox
            // 
            this.ARAC_KIRALAMA_OTOMASYONU_PictureBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ARAC_KIRALAMA_OTOMASYONU_PictureBox.Image = global::ARAC_KIRALAMA_OTOMASYONU.Properties.Resources.carwallpaper;
            this.ARAC_KIRALAMA_OTOMASYONU_PictureBox.Location = new System.Drawing.Point(20, 65);
            this.ARAC_KIRALAMA_OTOMASYONU_PictureBox.Name = "ARAC_KIRALAMA_OTOMASYONU_PictureBox";
            this.ARAC_KIRALAMA_OTOMASYONU_PictureBox.Size = new System.Drawing.Size(833, 433);
            this.ARAC_KIRALAMA_OTOMASYONU_PictureBox.TabIndex = 0;
            this.ARAC_KIRALAMA_OTOMASYONU_PictureBox.TabStop = false;
            // 
            // METROPROGRESSBAR
            // 
            this.METROPROGRESSBAR.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.METROPROGRESSBAR.Location = new System.Drawing.Point(20, 505);
            this.METROPROGRESSBAR.Name = "METROPROGRESSBAR";
            this.METROPROGRESSBAR.Size = new System.Drawing.Size(833, 35);
            this.METROPROGRESSBAR.Style = MetroFramework.MetroColorStyle.Green;
            this.METROPROGRESSBAR.TabIndex = 1;
            this.METROPROGRESSBAR.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PROGRESSBAR_ZAMAN
            // 
            this.PROGRESSBAR_ZAMAN.Enabled = true;
            this.PROGRESSBAR_ZAMAN.Tick += new System.EventHandler(this.PROGRESSBAR_ZAMAN_Tick);
            // 
            // GRS_EKRANI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 558);
            this.Controls.Add(this.METROPROGRESSBAR);
            this.Controls.Add(this.ARAC_KIRALAMA_OTOMASYONU_PictureBox);
            this.Font = new System.Drawing.Font("Haettenschweiler", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "GRS_EKRANI";
            this.Padding = new System.Windows.Forms.Padding(20, 65, 20, 22);
            this.Style = MetroFramework.MetroColorStyle.Green;
            this.Text = "ARAÇ KİRALAMA PROGRAMI";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.ARAC_KIRALAMA_OTOMASYONU_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion
        private System.Windows.Forms.PictureBox ARAC_KIRALAMA_OTOMASYONU_PictureBox;
        private MetroFramework.Controls.MetroProgressBar METROPROGRESSBAR;
        private System.Windows.Forms.Timer PROGRESSBAR_ZAMAN;
    }
}

