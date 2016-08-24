using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TreeView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            TreeNode tnroot=new TreeNode("Root");
            TreeNode tnchild=new TreeNode("Child");

            tnroot.Nodes.Add(tnchild);
            tnroot.Nodes.Add("chilf1");
            tnroot.Nodes.Add("child2");
            tnchild.Nodes.Add("baby1");

            treeView1.Nodes.Add(tnroot);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            MessageBox.Show(e.Node.Text);

        }


    }

}
