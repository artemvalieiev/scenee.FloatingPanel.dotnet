using Foundation;
using UIKit;

namespace FloatingPanel.Sample;

[Register("AppDelegate")]
public class AppDelegate : UIApplicationDelegate
{
    public override UIWindow? Window { get; set; }

    public override bool FinishedLaunching(UIApplication application, NSDictionary launchOptions)
    {
        
        // create a new window instance based on the screen size
        Window = new UIWindow(UIScreen.MainScreen.Bounds);

        // create a UIViewController with a single UILabel
        var mainViewController = UIStoryboard.FromName("Main", NSBundle.MainBundle).InstantiateViewController("MainViewController");
        var vc = new UINavigationController();
        vc.PushViewController(mainViewController, false);
        Window.RootViewController = vc;

        // make the window visible
        Window.MakeKeyAndVisible();

        return true;
    }
}