using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Ibterfaces__Textbox_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            textBoxMust1.ArkaPlanRengi = Color.DeepSkyBlue;
            textBoxMust1.ArkaPlanRengiDegistir();
            textBoxMust1.Genislik = 120;
            MessageBox.Show(textBoxMust1.Yukseklik.ToString());

        private void textBoxMust1_TextChanged(object sender, EventArgs e)
        {
            textBoxMust1.UpperCaseYap();
        }


    }
}
