namespace ResimUzerineYaziEkleme
{
    partial class Form1
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
            this.grpIslemler = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownY = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownX = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnYaziRengiGoster = new System.Windows.Forms.Button();
            this.lblSaydamlik = new System.Windows.Forms.Label();
            this.trkBSaydamlik = new System.Windows.Forms.TrackBar();
            this.btnYaziTipi = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.btnYaz = new System.Windows.Forms.Button();
            this.btnResimSec = new System.Windows.Forms.Button();
            this.btnYaziRengi = new System.Windows.Forms.Button();
            this.txtYazilacakYazi = new System.Windows.Forms.TextBox();
            this.lblYazi = new System.Windows.Forms.Label();
            this.grpResim = new System.Windows.Forms.GroupBox();
            this.pcBResim = new System.Windows.Forms.PictureBox();
            this.oFDResimSec = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.numericUpDownR = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.grpIslemler.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBSaydamlik)).BeginInit();
            this.grpResim.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcBResim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).BeginInit();
            this.SuspendLayout();
            // 
            // grpIslemler
            // 
            this.grpIslemler.Controls.Add(this.numericUpDownR);
            this.grpIslemler.Controls.Add(this.label4);
            this.grpIslemler.Controls.Add(this.label3);
            this.grpIslemler.Controls.Add(this.numericUpDownY);
            this.grpIslemler.Controls.Add(this.numericUpDownX);
            this.grpIslemler.Controls.Add(this.label2);
            this.grpIslemler.Controls.Add(this.label1);
            this.grpIslemler.Controls.Add(this.btnYaziRengiGoster);
            this.grpIslemler.Controls.Add(this.lblSaydamlik);
            this.grpIslemler.Controls.Add(this.trkBSaydamlik);
            this.grpIslemler.Controls.Add(this.btnYaziTipi);
            this.grpIslemler.Controls.Add(this.btnKayit);
            this.grpIslemler.Controls.Add(this.btnYaz);
            this.grpIslemler.Controls.Add(this.btnResimSec);
            this.grpIslemler.Controls.Add(this.btnYaziRengi);
            this.grpIslemler.Controls.Add(this.txtYazilacakYazi);
            this.grpIslemler.Controls.Add(this.lblYazi);
            this.grpIslemler.Location = new System.Drawing.Point(13, 13);
            this.grpIslemler.Name = "grpIslemler";
            this.grpIslemler.Size = new System.Drawing.Size(674, 166);
            this.grpIslemler.TabIndex = 0;
            this.grpIslemler.TabStop = false;
            this.grpIslemler.Text = "İşlemler";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(412, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(191, 26);
            this.label3.TabIndex = 10;
            this.label3.Text = "Font seçtiğiniz zaman yazı rengi \r\notomatik olarak siyah atanıyor...";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // numericUpDownY
            // 
            this.numericUpDownY.Location = new System.Drawing.Point(34, 102);
            this.numericUpDownY.Name = "numericUpDownY";
            this.numericUpDownY.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownY.TabIndex = 9;
            this.toolTip1.SetToolTip(this.numericUpDownY, "Yazının Y koordinatı.\r\n");
            this.numericUpDownY.ValueChanged += new System.EventHandler(this.numericUpDownY_ValueChanged);
            // 
            // numericUpDownX
            // 
            this.numericUpDownX.Location = new System.Drawing.Point(34, 80);
            this.numericUpDownX.Name = "numericUpDownX";
            this.numericUpDownX.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownX.TabIndex = 9;
            this.toolTip1.SetToolTip(this.numericUpDownX, "Yazının X koordinatı.");
            this.numericUpDownX.ValueChanged += new System.EventHandler(this.numericUpDownX_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Y:";
            this.toolTip1.SetToolTip(this.label2, "Yazının Y koordinatı.\r\n");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "X:";
            this.toolTip1.SetToolTip(this.label1, "Yazının X koordinatı.");
            // 
            // btnYaziRengiGoster
            // 
            this.btnYaziRengiGoster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYaziRengiGoster.FlatAppearance.BorderSize = 0;
            this.btnYaziRengiGoster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnYaziRengiGoster.Location = new System.Drawing.Point(13, 48);
            this.btnYaziRengiGoster.Name = "btnYaziRengiGoster";
            this.btnYaziRengiGoster.Size = new System.Drawing.Size(63, 24);
            this.btnYaziRengiGoster.TabIndex = 7;
            this.btnYaziRengiGoster.UseVisualStyleBackColor = true;
            this.btnYaziRengiGoster.Click += new System.EventHandler(this.btnYaziRengiGoster_Click);
            // 
            // lblSaydamlik
            // 
            this.lblSaydamlik.AutoSize = true;
            this.lblSaydamlik.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblSaydamlik.Location = new System.Drawing.Point(182, 105);
            this.lblSaydamlik.Name = "lblSaydamlik";
            this.lblSaydamlik.Size = new System.Drawing.Size(49, 18);
            this.lblSaydamlik.TabIndex = 6;
            this.lblSaydamlik.Text = "% 255";
            // 
            // trkBSaydamlik
            // 
            this.trkBSaydamlik.Location = new System.Drawing.Point(86, 82);
            this.trkBSaydamlik.Maximum = 255;
            this.trkBSaydamlik.Name = "trkBSaydamlik";
            this.trkBSaydamlik.Size = new System.Drawing.Size(231, 45);
            this.trkBSaydamlik.TabIndex = 5;
            this.trkBSaydamlik.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trkBSaydamlik.Value = 255;
            this.trkBSaydamlik.Scroll += new System.EventHandler(this.trkBSaydamlik_Scroll);
            // 
            // btnYaziTipi
            // 
            this.btnYaziTipi.Location = new System.Drawing.Point(207, 49);
            this.btnYaziTipi.Name = "btnYaziTipi";
            this.btnYaziTipi.Size = new System.Drawing.Size(110, 23);
            this.btnYaziTipi.TabIndex = 4;
            this.btnYaziTipi.Text = "Yazı Tipi";
            this.btnYaziTipi.UseVisualStyleBackColor = true;
            this.btnYaziTipi.Click += new System.EventHandler(this.btnYaziTipi_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.Location = new System.Drawing.Point(512, 18);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(155, 85);
            this.btnKayit.TabIndex = 3;
            this.btnKayit.Text = "Resmi Kaydet";
            this.btnKayit.UseVisualStyleBackColor = true;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(351, 67);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(155, 37);
            this.btnYaz.TabIndex = 3;
            this.btnYaz.Text = "Resim Üzerine Yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // btnResimSec
            // 
            this.btnResimSec.Location = new System.Drawing.Point(351, 18);
            this.btnResimSec.Name = "btnResimSec";
            this.btnResimSec.Size = new System.Drawing.Size(155, 37);
            this.btnResimSec.TabIndex = 3;
            this.btnResimSec.Text = "Resim ";
            this.btnResimSec.UseVisualStyleBackColor = true;
            this.btnResimSec.Click += new System.EventHandler(this.btnResimSec_Click);
            // 
            // btnYaziRengi
            // 
            this.btnYaziRengi.Location = new System.Drawing.Point(82, 49);
            this.btnYaziRengi.Name = "btnYaziRengi";
            this.btnYaziRengi.Size = new System.Drawing.Size(110, 23);
            this.btnYaziRengi.TabIndex = 2;
            this.btnYaziRengi.Text = "Yazı Rengi";
            this.btnYaziRengi.UseVisualStyleBackColor = true;
            this.btnYaziRengi.Click += new System.EventHandler(this.btnYaziRengi_Click);
            // 
            // txtYazilacakYazi
            // 
            this.txtYazilacakYazi.Location = new System.Drawing.Point(82, 22);
            this.txtYazilacakYazi.Name = "txtYazilacakYazi";
            this.txtYazilacakYazi.Size = new System.Drawing.Size(235, 20);
            this.txtYazilacakYazi.TabIndex = 1;
            this.toolTip1.SetToolTip(this.txtYazilacakYazi, "Resim üzerine yazılacak yazı.");
            this.txtYazilacakYazi.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtYazilacakYazi_KeyDown);
            // 
            // lblYazi
            // 
            this.lblYazi.AutoSize = true;
            this.lblYazi.Location = new System.Drawing.Point(43, 25);
            this.lblYazi.Name = "lblYazi";
            this.lblYazi.Size = new System.Drawing.Size(33, 13);
            this.lblYazi.TabIndex = 0;
            this.lblYazi.Text = "Yazı: ";
            // 
            // grpResim
            // 
            this.grpResim.Controls.Add(this.pcBResim);
            this.grpResim.Location = new System.Drawing.Point(13, 194);
            this.grpResim.Name = "grpResim";
            this.grpResim.Size = new System.Drawing.Size(675, 319);
            this.grpResim.TabIndex = 0;
            this.grpResim.TabStop = false;
            this.grpResim.Text = "Resim";
            // 
            // pcBResim
            // 
            this.pcBResim.Location = new System.Drawing.Point(11, 20);
            this.pcBResim.Name = "pcBResim";
            this.pcBResim.Size = new System.Drawing.Size(657, 291);
            this.pcBResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcBResim.TabIndex = 0;
            this.pcBResim.TabStop = false;
            // 
            // oFDResimSec
            // 
            this.oFDResimSec.FileName = "oFDResimSec";
            // 
            // numericUpDownR
            // 
            this.numericUpDownR.Location = new System.Drawing.Point(34, 128);
            this.numericUpDownR.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.numericUpDownR.Name = "numericUpDownR";
            this.numericUpDownR.Size = new System.Drawing.Size(42, 20);
            this.numericUpDownR.TabIndex = 12;
            this.toolTip1.SetToolTip(this.numericUpDownR, "Yazının Dönme Açısı");
            this.numericUpDownR.ValueChanged += new System.EventHandler(this.numericUpDownR_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(18, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "R:";
            this.toolTip1.SetToolTip(this.label4, "Yazının Dönme Açısı");
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 521);
            this.Controls.Add(this.grpResim);
            this.Controls.Add(this.grpIslemler);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Resim Üzerine Yazi Ekleme";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grpIslemler.ResumeLayout(false);
            this.grpIslemler.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trkBSaydamlik)).EndInit();
            this.grpResim.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcBResim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownR)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpIslemler;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button btnResimSec;
        private System.Windows.Forms.Button btnYaziRengi;
        private System.Windows.Forms.TextBox txtYazilacakYazi;
        private System.Windows.Forms.Label lblYazi;
        private System.Windows.Forms.GroupBox grpResim;
        private System.Windows.Forms.PictureBox pcBResim;
        private System.Windows.Forms.OpenFileDialog oFDResimSec;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnYaziTipi;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.TrackBar trkBSaydamlik;
        private System.Windows.Forms.Label lblSaydamlik;
        private System.Windows.Forms.Button btnYaziRengiGoster;
        private System.Windows.Forms.NumericUpDown numericUpDownY;
        private System.Windows.Forms.NumericUpDown numericUpDownX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

