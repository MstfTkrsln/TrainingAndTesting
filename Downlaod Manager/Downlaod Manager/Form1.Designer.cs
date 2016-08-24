namespace Downlaod_Manager
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
            this.btnDownload = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblAdres = new System.Windows.Forms.Label();
            this.lblIsım = new System.Windows.Forms.Label();
            this.lblBoyut = new System.Windows.Forms.Label();
            this.LblYuzde = new System.Windows.Forms.Label();
            this.Prgdownload = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // btnDownload
            // 
            this.btnDownload.BackColor = System.Drawing.Color.PaleTurquoise;
            this.btnDownload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDownload.Location = new System.Drawing.Point(447, 54);
            this.btnDownload.Name = "btnDownload";
            this.btnDownload.Size = new System.Drawing.Size(91, 23);
            this.btnDownload.TabIndex = 0;
            this.btnDownload.Text = "Download";
            this.btnDownload.UseVisualStyleBackColor = false;
            this.btnDownload.Click += new System.EventHandler(this.btnDownload_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(405, 20);
            this.textBox1.TabIndex = 1;
            // 
            // lblAdres
            // 
            this.lblAdres.AutoSize = true;
            this.lblAdres.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAdres.Location = new System.Drawing.Point(12, 35);
            this.lblAdres.Name = "lblAdres";
            this.lblAdres.Size = new System.Drawing.Size(49, 16);
            this.lblAdres.TabIndex = 2;
            this.lblAdres.Text = "Adres";
            // 
            // lblIsım
            // 
            this.lblIsım.AutoSize = true;
            this.lblIsım.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblIsım.Location = new System.Drawing.Point(12, 107);
            this.lblIsım.Name = "lblIsım";
            this.lblIsım.Size = new System.Drawing.Size(36, 16);
            this.lblIsım.TabIndex = 2;
            this.lblIsım.Text = "İsim";
            // 
            // lblBoyut
            // 
            this.lblBoyut.AutoSize = true;
            this.lblBoyut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblBoyut.Location = new System.Drawing.Point(12, 144);
            this.lblBoyut.Name = "lblBoyut";
            this.lblBoyut.Size = new System.Drawing.Size(47, 16);
            this.lblBoyut.TabIndex = 2;
            this.lblBoyut.Text = "Boyut";
            // 
            // LblYuzde
            // 
            this.LblYuzde.AutoSize = true;
            this.LblYuzde.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.LblYuzde.Location = new System.Drawing.Point(12, 182);
            this.LblYuzde.Name = "LblYuzde";
            this.LblYuzde.Size = new System.Drawing.Size(33, 16);
            this.LblYuzde.TabIndex = 2;
            this.LblYuzde.Text = "% 0";
            // 
            // Prgdownload
            // 
            this.Prgdownload.Location = new System.Drawing.Point(12, 216);
            this.Prgdownload.Name = "Prgdownload";
            this.Prgdownload.Size = new System.Drawing.Size(537, 23);
            this.Prgdownload.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightBlue;
            this.ClientSize = new System.Drawing.Size(560, 260);
            this.Controls.Add(this.Prgdownload);
            this.Controls.Add(this.LblYuzde);
            this.Controls.Add(this.lblBoyut);
            this.Controls.Add(this.lblIsım);
            this.Controls.Add(this.lblAdres);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDownload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDownload;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblAdres;
        private System.Windows.Forms.Label lblIsım;
        private System.Windows.Forms.Label lblBoyut;
        private System.Windows.Forms.Label LblYuzde;
        private System.Windows.Forms.ProgressBar Prgdownload;
    }
}

