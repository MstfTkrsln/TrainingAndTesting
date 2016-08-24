using System;
using System.Drawing;

using MonoTouch.CoreGraphics;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace IOS_Test
{
    [Register("UIView1")]
    public class UIView1 : UIView
    {
        public UIView1()
        {
            Initialize();
        }

        public UIView1(RectangleF bounds)
            : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Red;
        }
    }
}