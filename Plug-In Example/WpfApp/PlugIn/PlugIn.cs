using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PlugIn
{
    public class PlugIn:ApplicationObjects.IAppObject
    {

        public void Inıtialize(ApplicationObjects.AppObj appObj)
        {
            appObj.MessageButton1_Click += new EventHandler(appObj_MessageButton1_Click);
            appObj.MessageButton2_Click += new EventHandler(appObj_MessageButton2_Click);
        }

        void appObj_MessageButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PlugIn :" + sender.ToString());
        }

        void appObj_MessageButton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("PlugIn :" + sender.ToString());

        }
    }
}
