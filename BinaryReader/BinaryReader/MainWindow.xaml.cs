using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;

namespace BinaryReader
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public string directoryPath = @"Persons";
        public string filePath = @"Persons\Persons.txt";

        public MainWindow()
        {
            
            if (!Directory.Exists(directoryPath))
            {
                Directory.CreateDirectory(directoryPath);  
            }
            
            InitializeComponent();
        }
        
        private void btnWrite_Click(object sender, RoutedEventArgs e)
        {
            
            Person person=new Person(Convert.ToDecimal(txtId.Text),txtName.Text,txtSurname.Text,Convert.ToUInt32(txtAge.Text));
            
            try
            {
                
                using (
                    BinaryWriter bw = new BinaryWriter(File.Open(filePath, FileMode.Append,FileAccess.Write,FileShare.ReadWrite), Encoding.UTF8)
                    )
                {
                    
                    bw.Write(person.ToString());
                    bw.Write("\r\n");
                    bw.Flush();
                    

                 
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show("Writing Error :" + ex.Message);
            }
            ClearListFile();
        }
        
        private void btnRead_Click(object sender, RoutedEventArgs e)
        {
                    listFile.Items.Clear();
            try
            {
                if (File.Exists(filePath))
                {
                    using ( System.IO.BinaryReader br = new System.IO.BinaryReader(File.Open(filePath,FileMode.Open,FileAccess.Read,FileShare.ReadWrite),Encoding.UTF8))
                    {

                        StreamReader sr=new StreamReader(filePath);
                        
                        while (!sr.EndOfStream)
                        {
                            byte[] array = new byte[100];
                            int i = 0;
                            char temp;
                            do
                            {
                                temp = br.ReadChar();
                                array[i] = Convert.ToByte(temp);
                                i++;


                            } while (temp != '\n');

                            Array.Resize(ref array,i-3);
                            Array.Reverse(array);
                            Array.Resize(ref array,i-4);
                            Array.Reverse(array);

                            listFile.Items.Add(Encoding.UTF8.GetString(array));
                            sr.ReadLine();
                         } 
                        sr.Close();
                        
                    }
                    
                }

            }
            catch (Exception ex)
            {
                
               MessageBox.Show("Reading Error :" + ex.Message+"\nSource :"+ex.InnerException);

            }

        }

        private void btnDelete_Click(object sender, RoutedEventArgs e)
        {
            if (File.Exists(filePath))
            {
                File.Delete(filePath);
            }
            listFile.Items.Clear();
            ClearListFile();
        }
        
        private void listFile_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            
            try
            {
                string record = listFile.SelectedItem.ToString();

                string[] PersonInf = record.Split();

                txtId.Text = PersonInf[0];
                txtName.Text = PersonInf[1];
                txtSurname.Text = PersonInf[2];
                txtAge.Text = PersonInf[3];
            }
            catch (Exception ex)
            {
                
            }

        }

        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            if (listFile.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Record to Update");
            }
            else
            {


                listFile.Items[listFile.SelectedIndex] = txtId.Text + " " + txtName.Text + " " + txtSurname.Text + " " +
                                                         txtAge.Text;

                try
                {
                    File.Delete(filePath);
                    using (
                        BinaryWriter bw =
                            new BinaryWriter(File.Open(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite),
                                Encoding.UTF8)
                        )
                    {
                        foreach (var item in listFile.Items)
                        {

                            bw.Write(item.ToString());
                            bw.Write("\r\n");
                        }


                        bw.Flush();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Writing Error :" + ex.Message);
                }


                ClearListFile();
            }
        }
                
        void ClearListFile()
        {
            txtAge.Text = null;
            txtId.Text = null;
            txtName.Text = null;
            txtSurname.Text = null;
        }

        private void btnDeleteRecord_Click(object sender, RoutedEventArgs e)
        {
            if (listFile.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Record to Delete");
            }
            else
            {


                listFile.Items.Remove(listFile.SelectedItem);

                try
                {
                    File.Delete(filePath);
                    using (
                        BinaryWriter bw =
                            new BinaryWriter(File.Open(filePath, FileMode.Append, FileAccess.Write, FileShare.ReadWrite),
                                Encoding.UTF8)
                        )
                    {
                        
                        foreach (var item in listFile.Items)
                        {

                            bw.Write(item.ToString());
                            bw.Write("\r\n");
                        }


                        bw.Flush();
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Writing Error :" + ex.Message);
                }


            }
            ClearListFile();

        }

        
        private void txt_TurkishCharacters(object sender, TextChangedEventArgs e)
        {
            TextBox txt =(TextBox) sender;
            
            switch (txt.Text.Substring(txt.Text.Length - 1))
            {
                case "ş":
                    txt.Text = txt.Text.Replace('ş', 's');
                    txt.Select(txt.Text.Length,0);
                    break;
                case "ü":
                    txt.Text = txt.Text.Replace('ü', 'u');
                    txt.Select(txt.Text.Length, 0);
                    break;
                case "ö":
                    txt.Text = txt.Text.Replace('ö', 'o');
                    txt.Select(txt.Text.Length, 0);
                    break;
                case "İ":
                    txt.Text = txt.Text.Replace('İ', 'I');
                    txt.Select(txt.Text.Length, 0);
                    break;
                case "ğ":
                    txt.Text = txt.Text.Replace('ğ', 'g');
                    txt.Select(txt.Text.Length, 0);
                    break;
                case "ç":
                    txt.Text = txt.Text.Replace('ç', 'c');
                    txt.Select(txt.Text.Length, 0);
                    break;
                case "ı":
                    txt.Text = txt.Text.Replace('i', 'i');
                    txt.Select(txt.Text.Length, 0);
                    break;
            }
            
        }
        
        

    }
    
}
