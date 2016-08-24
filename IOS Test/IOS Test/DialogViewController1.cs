using System;
using System.Collections.Generic;
using System.Linq;

using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.Dialog;

namespace IOS_Test
{
    public partial class DialogViewController1 : DialogViewController
    {
        public DialogViewController1()
            : base(UITableViewStyle.Grouped, null)
        {
            Root = new RootElement("DialogViewController1") {
				new Section ("First Section"){
					new StringElement ("Hello", () => {
						new UIAlertView ("Hola", "Thanks for tapping!", null, "Continue").Show (); 
					}),
					new EntryElement ("Name", "Enter your name", String.Empty)
				},
				new Section ("Second Section"){
				},
			};
        }
    }
}