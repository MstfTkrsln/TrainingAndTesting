using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Interfaces__Textbox_
{
    public class TextBoxInterface
    {
        public interface ITextBox
        {

            int Genislik //interface ' i implement edecek olan textbox ' in Genislik ozelligi tanimlanir.
            { get; set; }

            int Yukseklik //Yukseklik ozelliginin degistirilmesini istemedigimiz icin readonly tanimlayalim
            { get; }

            System.Drawing.Color ArkaPlanRengi //Textbox ' in arkaplan rengi ozelligi
            { get; set; }

            void ArkaPlanRengiDegistir(); //TextBox ' in arkaplan rengini degistirecek
            void UpperCaseYap(); //TextBox ' a yazilan karakterleri buyuk harfe donusturecek
        }
    }
    public class TextBoxMust : System.Windows.Forms.TextBox, TextBoxInterface.ITextBox
    {
        #region Itextbox

        private int mGenislik;
        private int mYukseklik;
        private System.Drawing.Color mArkaplanRengi;


        public int Genislik
        {
            get { return mGenislik; }
            set { mGenislik = value;
                this.Width = value;
            }
        }

        public int Yukseklik
        {
            get { return mYukseklik; }
            
        }

        public Color ArkaPlanRengi
        {
            get { return mArkaplanRengi; }
            set { mArkaplanRengi = value; }
        }

        public void ArkaPlanRengiDegistir()
        {
           this.BackColor=ArkaPlanRengi;
        }

        public void UpperCaseYap()
        {
            this.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
        }
        
        #endregion

    }
    


}

