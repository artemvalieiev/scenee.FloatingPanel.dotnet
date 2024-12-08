﻿// This file has been autogenerated from a class added in the UI designer.

using System;
using FloatingPanel;
using Foundation;
using MapKit;
using UIKit;

namespace FloatingPanel.Sample;

public partial class MainViewController : UIViewController
{
	private FloatingPanelController fpc;

	public MainViewController(IntPtr handle) : base(handle)
	{
	}
	

	public override void ViewDidLoad()
	{
		base.ViewDidLoad();
		
		fpc = new FloatingPanelController();
		fpc.Delegate = new MainViewControllerFloatingPanelControllerDelegate();

		// Assign self as the delegate of the controller.

		// Set a content view controller.
		var contentVc = UIStoryboard.FromName("Main", NSBundle.MainBundle)
			.InstantiateViewController("SheetViewController");
		fpc.ContentViewController = new UINavigationController(contentVc)
		{
			NavigationBarHidden = true
		};
		fpc.AddPanelToParent(this, -1, false, null);
	}

	public override void ViewDidAppear(bool animated)
	{
		base.ViewDidAppear(animated);
		MapView.MapType = MKMapType.HybridFlyover;
		MapView.SetCenterCoordinate(new (47.498889,34.655833), true);
	}
}

public class MainViewControllerFloatingPanelControllerDelegate : FloatingPanelControllerDelegate
{
	
}