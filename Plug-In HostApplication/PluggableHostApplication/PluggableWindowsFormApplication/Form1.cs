using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PluggableCoreLibrary;
using Pluggable;

namespace PluggableWindowsFormApplication
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            m_cbCalculation.DisplayMember = "Operator";
            m_cbCalculation.DataSource = CalculatorHostProvider.Calculators;
        }

        private void m_btnCalculate_Click(object sender, EventArgs e)
        {
            CalculatorHost 
                calculator = m_cbCalculation.SelectedItem as CalculatorHost;

            if (null != calculator)
            {
                calculator.X = Convert.ToInt32(m_txtA.Text);
                calculator.Y = Convert.ToInt32(m_txtB.Text);
                m_lblResult.Text = calculator.ToString();
            }
        }
    }
}