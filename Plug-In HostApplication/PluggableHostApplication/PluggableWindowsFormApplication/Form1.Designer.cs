namespace PluggableWindowsFormApplication
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
            this.m_cbCalculation = new System.Windows.Forms.ComboBox();
            this.m_txtA = new System.Windows.Forms.TextBox();
            this.m_txtB = new System.Windows.Forms.TextBox();
            this.m_btnCalculate = new System.Windows.Forms.Button();
            this.m_lblResult = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // m_cbCalculation
            // 
            this.m_cbCalculation.FormattingEnabled = true;
            this.m_cbCalculation.Location = new System.Drawing.Point(58, 12);
            this.m_cbCalculation.Name = "m_cbCalculation";
            this.m_cbCalculation.Size = new System.Drawing.Size(41, 21);
            this.m_cbCalculation.TabIndex = 0;
            // 
            // m_txtA
            // 
            this.m_txtA.Location = new System.Drawing.Point(8, 12);
            this.m_txtA.Name = "m_txtA";
            this.m_txtA.Size = new System.Drawing.Size(44, 20);
            this.m_txtA.TabIndex = 1;
            // 
            // m_txtB
            // 
            this.m_txtB.Location = new System.Drawing.Point(105, 12);
            this.m_txtB.Name = "m_txtB";
            this.m_txtB.Size = new System.Drawing.Size(44, 20);
            this.m_txtB.TabIndex = 2;
            // 
            // m_btnCalculate
            // 
            this.m_btnCalculate.Location = new System.Drawing.Point(155, 12);
            this.m_btnCalculate.Name = "m_btnCalculate";
            this.m_btnCalculate.Size = new System.Drawing.Size(75, 23);
            this.m_btnCalculate.TabIndex = 3;
            this.m_btnCalculate.Text = "Calculate";
            this.m_btnCalculate.UseVisualStyleBackColor = true;
            this.m_btnCalculate.Click += new System.EventHandler(this.m_btnCalculate_Click);
            // 
            // m_lblResult
            // 
            this.m_lblResult.AutoSize = true;
            this.m_lblResult.Location = new System.Drawing.Point(8, 51);
            this.m_lblResult.Name = "m_lblResult";
            this.m_lblResult.Size = new System.Drawing.Size(35, 13);
            this.m_lblResult.TabIndex = 4;
            this.m_lblResult.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 104);
            this.Controls.Add(this.m_lblResult);
            this.Controls.Add(this.m_btnCalculate);
            this.Controls.Add(this.m_txtB);
            this.Controls.Add(this.m_txtA);
            this.Controls.Add(this.m_cbCalculation);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox m_cbCalculation;
        private System.Windows.Forms.TextBox m_txtA;
        private System.Windows.Forms.TextBox m_txtB;
        private System.Windows.Forms.Button m_btnCalculate;
        private System.Windows.Forms.Label m_lblResult;
    }
}

