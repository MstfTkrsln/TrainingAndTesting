using System.Windows.Forms;

namespace Ibterfaces__Textbox_
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
            this.textBoxMust1 = new Interfaces__Textbox_.TextBoxMust();
            this.textBoxMust2 = new Interfaces__Textbox_.TextBoxMust();
            this.textBoxMust3 = new Interfaces__Textbox_.TextBoxMust();
            this.SuspendLayout();
            // 
            // textBoxMust1
            // 
            this.textBoxMust1.ArkaPlanRengi = System.Drawing.Color.Empty;
            this.textBoxMust1.Genislik = 0;
            this.textBoxMust1.Location = new System.Drawing.Point(92, 96);
            this.textBoxMust1.Name = "textBoxMust1";
            this.textBoxMust1.Size = new System.Drawing.Size(100, 20);
            this.textBoxMust1.TabIndex = 0;
            this.textBoxMust1.TextChanged += new System.EventHandler(this.textBoxMust1_TextChanged);
            // 
            // textBoxMust2
            // 
            this.textBoxMust2.ArkaPlanRengi = System.Drawing.Color.Empty;
            this.textBoxMust2.Genislik = 0;
            this.textBoxMust2.Location = new System.Drawing.Point(76, 42);
            this.textBoxMust2.Name = "textBoxMust2";
            this.textBoxMust2.Size = new System.Drawing.Size(100, 20);
            this.textBoxMust2.TabIndex = 1;
            // 
            // textBoxMust3
            // 
            this.textBoxMust3.ArkaPlanRengi = System.Drawing.Color.Empty;
            this.textBoxMust3.Genislik = 0;
            this.textBoxMust3.Location = new System.Drawing.Point(92, 170);
            this.textBoxMust3.Name = "textBoxMust3";
            this.textBoxMust3.Size = new System.Drawing.Size(100, 20);
            this.textBoxMust3.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.textBoxMust3);
            this.Controls.Add(this.textBoxMust2);
            this.Controls.Add(this.textBoxMust1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Interfaces__Textbox_.TextBoxMust textBoxMust1;
        private Interfaces__Textbox_.TextBoxMust textBoxMust2;
        private Interfaces__Textbox_.TextBoxMust textBoxMust3;


    }
}

