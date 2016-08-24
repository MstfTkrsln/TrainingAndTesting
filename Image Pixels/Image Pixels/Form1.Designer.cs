namespace Image_Pixels
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
            this.pictureOriginal = new System.Windows.Forms.PictureBox();
            this.btnOpen = new System.Windows.Forms.Button();
            this.btnGetPixels = new System.Windows.Forms.Button();
            this.picGray = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnX = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureOriginal
            // 
            this.pictureOriginal.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureOriginal.Location = new System.Drawing.Point(92, 12);
            this.pictureOriginal.Name = "pictureOriginal";
            this.pictureOriginal.Size = new System.Drawing.Size(510, 283);
            this.pictureOriginal.TabIndex = 0;
            this.pictureOriginal.TabStop = false;
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(11, 12);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(75, 23);
            this.btnOpen.TabIndex = 1;
            this.btnOpen.Text = "Open";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // btnGetPixels
            // 
            this.btnGetPixels.Location = new System.Drawing.Point(292, 301);
            this.btnGetPixels.Name = "btnGetPixels";
            this.btnGetPixels.Size = new System.Drawing.Size(96, 32);
            this.btnGetPixels.TabIndex = 2;
            this.btnGetPixels.Text = "Get Pixels";
            this.btnGetPixels.UseVisualStyleBackColor = true;
            this.btnGetPixels.Click += new System.EventHandler(this.btnGetPixels_Click);
            // 
            // picGray
            // 
            this.picGray.Location = new System.Drawing.Point(92, 365);
            this.picGray.Name = "picGray";
            this.picGray.Size = new System.Drawing.Size(510, 378);
            this.picGray.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picGray.TabIndex = 3;
            this.picGray.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(11, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Gray";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnX
            // 
            this.btnX.ForeColor = System.Drawing.Color.Red;
            this.btnX.Location = new System.Drawing.Point(11, 720);
            this.btnX.Name = "btnX";
            this.btnX.Size = new System.Drawing.Size(75, 23);
            this.btnX.TabIndex = 5;
            this.btnX.Text = "X";
            this.btnX.UseVisualStyleBackColor = true;
            this.btnX.Click += new System.EventHandler(this.btnX_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 753);
            this.Controls.Add(this.btnX);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.picGray);
            this.Controls.Add(this.btnGetPixels);
            this.Controls.Add(this.btnOpen);
            this.Controls.Add(this.pictureOriginal);
            this.Name = "Form1";
            this.Text = "picOriginal";
            ((System.ComponentModel.ISupportInitialize)(this.pictureOriginal)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGray)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureOriginal;
        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.Button btnGetPixels;
        private System.Windows.Forms.PictureBox picGray;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnX;
    }
}

