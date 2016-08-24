using System;
using System.Windows.Forms;

namespace Command_Pattern_Winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            cmbCommand.Items.Add(EnumCommands.Datetime);
            cmbCommand.Items.Add(EnumCommands.RandomColor);
            cmbCommand.Items.Add(EnumCommands.RandomVal);
        }

        private void btnAddCommand_Click(object sender, EventArgs e)
        {

            try
            {
                switch ((EnumCommands)cmbCommand.SelectedItem)
                {
                    case EnumCommands.Datetime:

                        listCommand.Items.Add(new Program.CommandDate());
                        break;
                    case EnumCommands.RandomColor:
                        listCommand.Items.Add(new Program.CommandRandomColor());
                        break;
                    case EnumCommands.RandomVal:
                        listCommand.Items.Add(new Program.ComamndRandomVal());
                        break;
                    default:
                        MessageBox.Show("Hatalı Seçim"); break;

                }
            }
            catch (Exception)
            {
                
                MessageBox.Show("Hatalı Seçim");
                
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (Program.ICommand command in listCommand.Items)
            {
                command.Execute(this);
            }
        }

        private void cmbCommand_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}