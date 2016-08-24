namespace Pointers_and_BitmapData
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
            this.picNew = new System.Windows.Forms.PictureBox();
            this.btnGetPixels = new System.Windows.Forms.Button();
            this.picOriginal = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).BeginInit();
            this.SuspendLayout();
            // 
            // picNew
            // 
            this.picNew.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picNew.Location = new System.Drawing.Point(12, 430);
            this.picNew.Name = "picNew";
            this.picNew.Size = new System.Drawing.Size(551, 370);
            this.picNew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picNew.TabIndex = 7;
            this.picNew.TabStop = false;
            // 
            // btnGetPixels
            // 
            this.btnGetPixels.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGetPixels.Location = new System.Drawing.Point(74, 392);
            this.btnGetPixels.Name = "btnGetPixels";
            this.btnGetPixels.Size = new System.Drawing.Size(411, 32);
            this.btnGetPixels.TabIndex = 6;
            this.btnGetPixels.Text = " Transfer with BitmapData ";
            this.btnGetPixels.UseVisualStyleBackColor = true;
            this.btnGetPixels.Click += new System.EventHandler(this.btnGetPixels_Click);
            // 
            // picOriginal
            // 
            this.picOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picOriginal.Location = new System.Drawing.Point(12, 12);
            this.picOriginal.Name = "picOriginal";
            this.picOriginal.Size = new System.Drawing.Size(551, 370);
            this.picOriginal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOriginal.TabIndex = 4;
            this.picOriginal.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOpen.Location = new System.Drawing.Point(569, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(96, 32);
            this.btnOpen.TabIndex = 8;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(682, 812);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.picNew);
            this.Controls.Add(this.btnGetPixels);
            this.Controls.Add(this.picOriginal);
            this.Name = "Form1";
            this.Text = "Form1";
            
            ((System.ComponentModel.ISupportInitialize)(this.picNew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picOriginal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picNew;
        private System.Windows.Forms.Button btnGetPixels;
        private System.Windows.Forms.PictureBox picOriginal;
        private System.Windows.Forms.Button btnOpen;
    }
}

