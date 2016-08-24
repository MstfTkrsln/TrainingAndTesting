using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Dinamik_Kontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            int x;
            Button[] btn=new Button[5];
            TextBox[] txt=new TextBox[5];

            for (int i = 0; i < 5; i++)
            {
                btn[i]=new Button();
                btn[i].Text = (i + 1).ToString();
                btn[i].Size=new Size(20,20);
                btn[i].Location=new Point(10,(i+1)*25);
                btn[i].Click += new EventHandler(btn_Click);
                pnlEkran.Controls.Add(btn[i]);

                txt[i]=new TextBox();
                txt[i].Size=new Size(40,20);
                txt[i].Tag = i + 1;
                txt[i].Location=new Point(50,(i+1)*25);
                pnlEkran.Controls.Add(txt[i]);

            }

        }

        void btn_Click(object sender, EventArgs e)
        {
            Button btn = (Button) sender;

            
            foreach (var item in pnlEkran.Controls)
            {
                if (item.GetType()==typeof(TextBox))
                {
                    TextBox txt = (TextBox) item;

                    if (Convert.ToInt16(txt.Tag)==Convert.ToInt16(btn.Text))
                    {
                        txt.Text = btn.Text;
                    }
                }
            }

            

        }
    }
}
