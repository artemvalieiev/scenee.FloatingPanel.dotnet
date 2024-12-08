﻿// This file has been autogenerated from a class added in the UI designer.

using System;

using Foundation;
using UIKit;

namespace FloatingPanel.Sample
{
	public partial class SheetViewController : UIViewController
	{
		public SheetViewController(IntPtr handle) : base(handle)
		{
		}

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();
			NavigationButton2.TouchUpInside += (sender, e) =>
			{
				var vc = UIStoryboard.FromName("Main", NSBundle.MainBundle).InstantiateViewController("SheetViewController");
				NavigationController.PushViewController(vc, true);
			};
		}
	}
}