using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using CoreGraphics;
using Foundation;
using NavigationTest;
using NavigationTest.iOS;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(CustomView), typeof(CustomRenderer))]
namespace NavigationTest.iOS
{
    public class CustomRenderer : ViewRenderer<CustomView, NativeView>
    {
        protected override void OnElementChanged(ElementChangedEventArgs<CustomView> e)
        {
            base.OnElementChanged(e);
            if(e.NewElement != null)
            {
                var nativeView = new NativeView();
                SetNativeControl(nativeView);
            }
        }
        public static new void Init()
        {
            new CustomRenderer();
        }

    }
    public class NativeView : UITextView
    {
        public NativeView() : base()
        {
            this.BackgroundColor = UIColor.Clear;
        }
           
        public override void Draw(CGRect rect)
        {
            base.Draw(rect);
        }
    }
}