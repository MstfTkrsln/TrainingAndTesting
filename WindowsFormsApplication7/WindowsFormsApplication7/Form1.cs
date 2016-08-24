using System;
using System.Windows.Forms;

namespace WindowsFormsApplication7
{
    public partial class Form1 : Form
    {
Random rnd = new Random();
        string[] filmler = new string[]
                                       {
                                          "HOUSE", "SPARTACUS", "BREAKING BAD", "SHAMELESS", "THE MENTALIST", "FRINGE", "ALCATRAZ", "GAME OF THRONES", "NEW GIRL", "SUPERNATURAL", "HOW I MET YOUR MOTHER", "THE GODFATHER", "INCEPTION", "THE DARK KNIGHT", "THE LORD OF THE RINGS", "STAR WARS", "FIGHT CLUB", "THE MATRIX", "THE USUAL SUSPECTS", "PSYCHO", "THE SILENCE OF THE LAMBS", "MEMENTO", "AMERICAN BEAUTY", "ALIEN", "THE SHINING", "THE PIANIST", "BACK TO THE FUTURE"
                                       };
       int txtSayisi = 0;
        public Form1()
        {
        
           
        }
              private void btnBaslat_Click(object sender, EventArgs e)
        {
            txtSayisi = 0;
            label1.Text = "Kalan hakkınız : "+ hak;
            flowLayoutPanel1.Controls.Clear();
            int index = rnd.Next(0, filmler.Length);
            string turetilen = filmler[index];
            char[] karakterler = turetilen.ToCharArray();
            for (int i = 0; i < karakterler.Length; i++)
            {
                if (i % 3 == 0 && karakterler[i] != ' ')
                {
                    TextBox txt = new TextBox();
                    txt.Width = 15;
                    txt.Height = 15;
                    txt.Tag = karakterler[i].ToString();
                    txt.TextChanged += new EventHandler(txt_TextChanged);
                    flowLayoutPanel1.Controls.Add(txt);
                    txtSayisi++;
                    continue;
                }
                Label lbl = new Label();
                lbl.Width = 15;
                lbl.Height = 15;
                lbl.Tag = karakterler[i].ToString();
                lbl.Text = karakterler[i].ToString();
                flowLayoutPanel1.Controls.Add(lbl);
                pb1.Visible = false;
                pb2.Visible = false;
                pb3.Visible = false;
                pb4.Visible = false;
                pb5.Visible = false;
                pb6.Visible = false;
                pb7.Visible = false;
                pb8.Visible = false;
                pb9.Visible = false;
            }
        }
        private void txt_TextChanged(object sender, EventArgs e)
        {
            TextBox txt = sender as TextBox;
            if (txt.Text.Length > 1)
            {
                MessageBox.Show("Lütfen Tek Karakter Giriniz!");
                txt.Clear();
            }
            else
            {
                txt.Text = txt.Text.ToUpper();
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pb1.Visible = false;
            pb2.Visible = false;
            pb3.Visible = false;
            pb4.Visible = false;
            pb5.Visible = false;
            pb6.Visible = false;
            pb7.Visible = false;
            pb8.Visible = false;
            pb9.Visible = false;
            label1.Text = "Kalan hakkınız : "+ hak;
        }
        private int hata = 0, hak = 9;
        private void btnTahminEt_Click(object sender, EventArgs e)
        {
            foreach (var ctrls in flowLayoutPanel1.Controls)
            {
                if (ctrls is TextBox)
                {
                    TextBox txt = ctrls as TextBox;
                    if (!string.IsNullOrWhiteSpace(txt.Text))
                    {
                        if (txt.Text != txt.Tag.ToString())
                        {
                            hak--;
                            hata++;
                            switch (hak)
                            {
                                case 8:
                                    pb1.Visible = true;
                                    break;
                                case 7:
                                    pb2.Visible = true;
                                    break;
                                case 6:
                                    pb3.Visible = true;
                                    break;
                                case 5:
                                    pb4.Visible = true;
                                    break;
                                case 4:
                                    pb5.Visible = true;
                                    break;
                                case 3:
                                    pb6.Visible = true;
                                    break;
                                case 2:
                                    pb7.Visible = true;
                                    break;
                                case 1:
                                    pb8.Visible = true;
                                    break;
                                case 0:
                                    pb9.Visible = true;
                                    label1.Text = "Kalan hakkınız : " + hak;
                                    MessageBox.Show("Üzgünüm asıldın :D ");
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            label1.Text = "Kalan hakkınız : "+ hak;
        }
    }
}
