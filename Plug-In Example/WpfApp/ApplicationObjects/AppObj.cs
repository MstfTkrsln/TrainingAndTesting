using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ApplicationObjects
{
    public class AppObj
    {
        public event EventHandler MessageButton1_Click;
        public event EventHandler MessageButton2_Click;

        public void RaiseMessageButton1Event()
        {
            MessageButton1_Click("Button1 Tıklandı",new EventArgs());
        }

        public void RaiseMessageButton2Event()
        {
            MessageButton2_Click("Button2 Tıklandı", new EventArgs());
        }

        public AppObj()
        {
            
        }
    }
}
