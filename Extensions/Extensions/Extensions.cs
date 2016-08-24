using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Windows.Controls;

namespace Extensions
{
    class single
    {
        private single()
        {
            
        }
        public static single getsingle()
        {
            return new single();
        }
        
        
    }
    public static class extensions
    {
        public static string ChangeChars(this string s)
        {
            return
                s.Replace("ğ", "g")
                    .Replace("ü", "u")
                    .Replace("İ", "I")
                    .Replace("ş", "s")
                    .Replace("ç", "c")
                    .Replace("ö", "o")
                    .Replace("ı", "i");
        }

        public static TextBox ChangeChars(this TextBox txt)
        {
            txt.Text = txt.Text.ChangeChars();
            return txt;
        }
    }
}
