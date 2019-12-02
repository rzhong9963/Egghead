using CoreGraphics;
using Foundation;
using System.Drawing;
using UIKit;

// Custom controller for iOS
// May not be used

namespace Egghead.iOS
{
    [Register("UniversalView")]
    public class UniversalView : UIView
    {
        public UniversalView()
        {
            Initialize();
        }

        public UniversalView(RectangleF bounds) : base(bounds)
        {
            Initialize();
        }

        void Initialize()
        {
            BackgroundColor = UIColor.Red;
        }
    }

    [Register("MainController")]
    public class MainController : UIViewController
    {
        public MainController()
        {
        }

        public override void DidReceiveMemoryWarning()
        {
            // Releases the view if it doesn't have a superview.
            base.DidReceiveMemoryWarning();

            // Release any cached data, images, etc that aren't in use.
        }

        UITextField username;



        public override void ViewDidLoad()
        {

            View = new UniversalView();

            base.ViewDidLoad();

            // Perform any additional setup after loading the view

            View.BackgroundColor = UIColor.LightGray;
            Title = "Main"; // Temp name to test Controller

            var btn = UIButton.FromType(UIButtonType.System);
            btn.Frame = new CGRect(20, 200, 280, 44); // Off center button
            btn.SetTitle("tAkE mE tO tHe PuRpLe", UIControlState.Normal); // A random button name

            var user = new UIViewController();
            user.View.BackgroundColor = UIColor.Purple;

            btn.TouchUpInside += (sender, e) =>
            {
                this.NavigationController.PushViewController(user, true);
            };

            View.AddSubview(btn);
        }
    }
}