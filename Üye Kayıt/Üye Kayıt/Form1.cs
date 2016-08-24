using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Üye_Kayıt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox2.SelectedIndex = 0;
        }

        public void Temizle()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            dateTimePicker1.Text = "";
            comboBox2.Text = "";
            dateTimePicker2.Text = "";


        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Boş alanları Doldurunuz.","..::UYARI::..", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                uyeler uye=new uyeler();
                uye.UyeNo = Convert.ToInt32(textBox1.Text);
                uye.Ad = textBox2.Text;
                uye.Soyad = textBox3.Text;
                uye.UyeDogumTarih = dateTimePicker1.Value;
                uye.Cinsiyet = comboBox2.SelectedItem.ToString();
                uye.UyelikTarihi = dateTimePicker2.Value;
                listBox1.Items.Add(uye);
                MessageBox.Show("Kayıt Eklendi", "..:: Başarılı İşlem ::..",
                 MessageBoxButtons.OK, MessageBoxIcon.Question);
                Temizle();
                

            }
        }


    }
}
