using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using NHibernate;
using  NHibernate.Cfg;
using NHibernateTest.Basin;

namespace NHibernateTest
{
    public partial class Form1 : Form
    {
        private Configuration myConfiguration;
        private ISessionFactory mySessionFactory;
        private ISession mySession;

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            myConfiguration =new Configuration();
            myConfiguration.Configure();
            mySessionFactory = myConfiguration.BuildSessionFactory();
            mySession = mySessionFactory.OpenSession();

            //using (mySession.BeginTransaction())
            //{
            //    Gazete gazete = new Gazete { Name = "Berk", Sales = 5 };
            //    mySession.Save(gazete);
            //    mySession.Transaction.Commit();
            //}


             //kaydedilen veriler veritabanından okunuyor
            

            IList gazeteList = mySession.CreateCriteria(typeof(Gazete)).List();

            foreach (Gazete item in gazeteList)
            {
                listBox1.Items.Add(item.Name.TrimEnd() +" "+ item.Sales);
            }

            mySession.Close();

        }
    }
}
