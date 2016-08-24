using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ResimUzerineYaziEkleme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Color yaziRengi;
        Font yaziTipi;
        Bitmap yeniResim;
        Point konum;
        string dosyaYolu = "";
        bool YaziYazilDiMi = false;
        int maxx = 0, maxy = 100;
        private void btnYaziRengi_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                yaziRengi = colorDialog1.Color;
                trkBSaydamlik.Enabled = true;
                btnYaziRengiGoster.BackColor = Color.FromArgb(int.Parse(trkBSaydamlik.Value.ToString()), yaziRengi);
                btnYaziRengiGoster.FlatAppearance.BorderColor = yaziRengi;
                if (YaziYazilDiMi)
                {
                    YaziYaz();

                }
            }
        }

        private void btnResimSec_Click(object sender, EventArgs e)
        {
            oFDResimSec.Title = "Resim Seç...";
            oFDResimSec.FileName = "";
            oFDResimSec.Filter = " Resim Dosyaları | *.jpg; *.png; *. bmp; ";
            if (oFDResimSec.ShowDialog() == DialogResult.OK)
            {
                dosyaYolu = oFDResimSec.FileName;
                pcBResim.Image = Image.FromFile(dosyaYolu);
                maxx = int.Parse(pcBResim.Image.Width.ToString());
                maxy = int.Parse(pcBResim.Image.Height.ToString());
                numericUpDownX.Maximum = maxx;
                numericUpDownY.Maximum = maxy;
            }
        }

        private void btnYaziTipi_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {

                yaziTipi = fontDialog1.Font;
                trkBSaydamlik.Enabled = true;
                btnYaziRengiGoster.BackColor = Color.FromArgb(int.Parse(trkBSaydamlik.Value.ToString()), fontDialog1.Color);
                if (YaziYazilDiMi)
                {
                    YaziYaz();

                }
            }

        }
        void YaziYaz()
        {
            try
            {
                if (yaziRengi != null && yaziTipi != null && dosyaYolu != "" && txtYazilacakYazi.Text != "")
                {
                    konum.X = int.Parse(numericUpDownX.Value.ToString());
                    konum.Y = int.Parse(numericUpDownY.Value.ToString());
                    yeniResim = new Bitmap(dosyaYolu);
                    Brush firca = new LinearGradientBrush(new Point(1, 1), new Point(100, 100), Color.FromArgb(trkBSaydamlik.Value, yaziRengi), Color.FromArgb(trkBSaydamlik.Value, yaziRengi));

                    Graphics gr = Graphics.FromImage(yeniResim);
                    gr.RotateTransform(float.Parse(numericUpDownR.Value.ToString()));
                    gr.DrawString(txtYazilacakYazi.Text, yaziTipi, firca, konum);
                    gr.RotateTransform(-float.Parse(numericUpDownR.Value.ToString()));
                    pcBResim.Image = yeniResim;
                    YaziYazilDiMi = true;
                }
                else if (dosyaYolu == "")
                {
                    MessageBox.Show("Yazı Yazmak İstediğiniz Resmi Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtYazilacakYazi.Text == "")
                {
                    MessageBox.Show("Yazmak İstediğiniz Yazıyı Giriniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (yaziTipi == null)
                {
                    MessageBox.Show("Yazı Tipini Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (yaziRengi == null)
                {
                    MessageBox.Show("Yazı Rengini Seçiniz...", "Uyarı..!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }



            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString(), "Sistem Kaynaklı Hata..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnYaz_Click(object sender, EventArgs e)
        {
            YaziYaz();
        }

        private void trkBSaydamlik_Scroll(object sender, EventArgs e)
        {

            lblSaydamlik.Text = "% " + trkBSaydamlik.Value;
            btnYaziRengiGoster.BackColor = Color.FromArgb(int.Parse(trkBSaydamlik.Value.ToString()), yaziRengi);
            if (YaziYazilDiMi)
            {
                YaziYaz();

            }

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            trkBSaydamlik.Enabled = false;
            btnYaziRengiGoster.FlatAppearance.BorderColor = Color.FromArgb(0, 255, 255, 255);
        }

        private void btnYaziRengiGoster_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                yaziRengi = colorDialog1.Color;
                trkBSaydamlik.Enabled = true;
                btnYaziRengiGoster.BackColor = Color.FromArgb(int.Parse(trkBSaydamlik.Value.ToString()), yaziRengi);
                btnYaziRengiGoster.FlatAppearance.BorderColor = yaziRengi;
                if (YaziYazilDiMi)
                {
                    YaziYaz();

                }
            }
        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            try
            {
                saveFileDialog1.Filter = "Resim Dosyası|*.png;";

                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    pcBResim.Image.Save(saveFileDialog1.FileName);
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message.ToString(), "Sistem Kaynaklı Hata..!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void numericUpDownX_ValueChanged(object sender, EventArgs e)
        {
            if (YaziYazilDiMi)
            {
                YaziYaz();

            }
        }

        private void numericUpDownY_ValueChanged(object sender, EventArgs e)
        {
            if (YaziYazilDiMi)
            {
                YaziYaz();

            }
        }

        private void txtYazilacakYazi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (YaziYazilDiMi)
                {
                    YaziYaz();
                }
            }
        }

        private void numericUpDownR_ValueChanged(object sender, EventArgs e)
        {
            if (YaziYazilDiMi)
            {
                YaziYaz();

            }
        }
    }
}