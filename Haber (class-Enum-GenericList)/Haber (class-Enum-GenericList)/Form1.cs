using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using Markalar;


namespace Haber__class_Enum_GenericList_
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnEkle_Click(object sender, EventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Audi a = new Audi();
            //Mercedes m=new Mercedes();
            //Bmw b=new Bmw();
            //comboBox1.Items.Add(a.ToString());
            //comboBox1.Items.Add(b.ToString());
            //comboBox1.Items.Add(m.ToString());

            string[] Cars =
                Directory.GetFiles(
                    @"C:\Users\Administrator\Documents\visual studio 2010\Projects\Haber (class-Enum-GenericList)\Markalar\bin\Debug\",
                    "*.dll");
            foreach (string item in Cars)
            {
                Assembly asm = Assembly.LoadFile(item);

                var tipler = Assembly.GetAssembly(typeof(Icarable)).GetTypes().Where(p=>p.IsClass).ToList();
                foreach (Type tip in tipler)
                {
                    var obj=Activator.CreateInstance(tip);
                    
                   if ((obj as Icarable)!=null)
                   {
                       comboBox1.Items.Add(tip);
                       Icarable icar = (Icarable) Activator.CreateInstance(tip);
                   }
                }
            }
            
        }
    }
}
