using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Command_Pattern_Winform
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        

        public interface ICommand
        {
           void Execute(Form1 f);
        }

        public class CommandDate:ICommand
        {

            public void Execute(Form1 f)
            {
                MessageBox.Show(DateTime.Now.ToLongDateString());
            }
        }
        public class CommandRandomColor: ICommand
        {

            public void Execute(Form1 f)
            {
                Random rnd=new Random();
                Color rndColor = Color.FromArgb(rnd.Next(0, 255), rnd.Next(0, 255), rnd.Next(0, 255));
                f.BackColor = rndColor;
                MessageBox.Show("Executing...");
            }
        }
        public class ComamndRandomVal : ICommand
        {

            public void Execute(Form1 f)
            {
                Random rnd=new Random();
                MessageBox.Show(rnd.Next().ToString());

            }
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
