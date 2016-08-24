using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fakülte_Ders_Kayıt
{
    public partial class Giris_form : Form
    {
        public Giris_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Giris_form form_giris=new Giris_form();
            Ana_form form_ana=new Ana_form();
            form_ana.Show();
            this.Visible = false;


        }

     

    }
}
