using System;
using CoreFoundation;
using Foundation;
using ObjCRuntime;
using CoreGraphics;
using UIKit;

namespace Scenee.FloatingPanel;

// @interface FloatingPanelBackdropView : UIView
[BaseType(typeof(UIView))]
interface FloatingPanelBackdropView
{
	// @property (nonatomic, strong) UITapGestureRecognizer * _Nonnull dismissalTapGestureRecognizer;
	[Export("dismissalTapGestureRecognizer", ArgumentSemantic.Strong)]
	UITapGestureRecognizer DismissalTapGestureRecognizer { get; set; }
}

// @protocol FloatingPanelLayoutAnchoring
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
//[Protocol (Name = "_TtP13FloatingPanel28FloatingPanelLayoutAnchoring_")]
[Protocol(Name = "FloatingPanelLayoutAnchoring")]
[Model]
[BaseType(typeof(NSObject))]
interface FloatingPanelLayoutAnchoring : ObjCRuntime.INativeObject
{
	// @required @property (readonly, nonatomic) enum FloatingPanelLayoutReferenceGuide referenceGuide;
	[Abstract]
	[Export ("referenceGuide")]
	FloatingPanelLayoutReferenceGuide ReferenceGuide { get; }

	// @required -(NSArray<NSLayoutConstraint *> * _Nonnull)layoutConstraints:(FloatingPanelController * _Nonnull)fpc for:(enum FloatingPanelPosition)position __attribute__((warn_unused_result("")));
	[Abstract]
	[Export ("layoutConstraints:for:")]
	NSLayoutConstraint[] For (FloatingPanelController fpc, FloatingPanelPosition position);
}

// @interface FloatingPanelAdaptiveLayoutAnchor : NSObject <FloatingPanelLayoutAnchoring>
//[BaseType (typeof(NSObject), Name = "_TtC13FloatingPanel33FloatingPanelAdaptiveLayoutAnchor")]
[BaseType(typeof(NSObject), Name = "FloatingPanelAdaptiveLayoutAnchor")]
[DisableDefaultCtor]
interface FloatingPanelAdaptiveLayoutAnchor : FloatingPanelLayoutAnchoring
{
	// -(instancetype _Nonnull)initWithAbsoluteOffset:(CGFloat)absoluteOffset contentLayout:(UILayoutGuide * _Nonnull)contentLayout referenceGuide:(enum FloatingPanelLayoutReferenceGuide)referenceGuide contentBoundingGuide:(enum FloatingPanelLayoutContentBoundingGuide)contentBoundingGuide __attribute__((objc_designated_initializer));
	[Export ("initWithAbsoluteOffset:contentLayout:referenceGuide:contentBoundingGuide:")]
	[DesignatedInitializer]
	NativeHandle InitWithAbsoluteOffset (nfloat absoluteOffset, UILayoutGuide contentLayout, FloatingPanelLayoutReferenceGuide referenceGuide, FloatingPanelLayoutContentBoundingGuide contentBoundingGuide);

	// -(instancetype _Nonnull)initWithFractionalOffset:(CGFloat)fractionalOffset contentLayout:(UILayoutGuide * _Nonnull)contentLayout referenceGuide:(enum FloatingPanelLayoutReferenceGuide)referenceGuide contentBoundingGuide:(enum FloatingPanelLayoutContentBoundingGuide)contentBoundingGuide __attribute__((objc_designated_initializer));
	[Export ("initWithFractionalOffset:contentLayout:referenceGuide:contentBoundingGuide:")]
	[DesignatedInitializer]
	NativeHandle InitWithFractionalOffset (nfloat fractionalOffset, UILayoutGuide contentLayout, FloatingPanelLayoutReferenceGuide referenceGuide, FloatingPanelLayoutContentBoundingGuide contentBoundingGuide);

	// @property (readonly, nonatomic) enum FloatingPanelLayoutReferenceGuide referenceGuide;
	[Export ("referenceGuide")]
	FloatingPanelLayoutReferenceGuide ReferenceGuide { get; }

	// @property (readonly, nonatomic) enum FloatingPanelLayoutContentBoundingGuide contentBoundingGuide;
	[Export ("contentBoundingGuide")]
	FloatingPanelLayoutContentBoundingGuide ContentBoundingGuide { get; }
}

// @interface FloatingPanel_Swift_395 (FloatingPanelAdaptiveLayoutAnchor)
[Category]
[BaseType (typeof(FloatingPanelAdaptiveLayoutAnchor))]
interface FloatingPanelAdaptiveLayoutAnchor_FloatingPanel_Swift_395
{
	// -(NSArray<NSLayoutConstraint *> * _Nonnull)layoutConstraints:(FloatingPanelController * _Nonnull)vc for:(enum FloatingPanelPosition)position __attribute__((warn_unused_result("")));
	[Export ("layoutConstraints:for:")]
	NSLayoutConstraint[] LayoutConstraints (FloatingPanelController vc, FloatingPanelPosition position);
}

// @protocol FloatingPanelBehavior
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/
//[Protocol,Model (Name = "_TtP13FloatingPanel21FloatingPanelBehavior_")]
[Protocol(Name = "FloatingPanelBehavior")]

[BaseType (typeof(NSObject))]
interface FloatingPanelBehavior
{
	// @optional @property (readonly, nonatomic) CGFloat springDecelerationRate;
	[Export ("springDecelerationRate")]
	nfloat SpringDecelerationRate { get; }

	// @optional @property (readonly, nonatomic) CGFloat springResponseTime;
	[Export ("springResponseTime")]
	nfloat SpringResponseTime { get; }

	// @optional @property (readonly, nonatomic) CGFloat momentumProjectionRate;
	[Export ("momentumProjectionRate")]
	nfloat MomentumProjectionRate { get; }

	// @optional -(BOOL)shouldProjectMomentum:(FloatingPanelController * _Nonnull)fpc to:(FloatingPanelState * _Nonnull)proposedState __attribute__((warn_unused_result("")));
	[Export ("shouldProjectMomentum:to:")]
	bool ShouldProjectMomentum (FloatingPanelController fpc, FloatingPanelState proposedState);

	// @optional -(CGFloat)redirectionalProgress:(FloatingPanelController * _Nonnull)fpc from:(FloatingPanelState * _Nonnull)from to:(FloatingPanelState * _Nonnull)to __attribute__((warn_unused_result("")));
	[Export ("redirectionalProgress:from:to:")]
	nfloat RedirectionalProgress (FloatingPanelController fpc, FloatingPanelState from, FloatingPanelState to);

	// @optional -(BOOL)allowsRubberBandingFor:(UIRectEdge)edge __attribute__((warn_unused_result("")));
	[Export ("allowsRubberBandingFor:")]
	bool AllowsRubberBandingFor (UIRectEdge edge);

	// @optional @property (readonly, nonatomic) CGFloat removalInteractionVelocityThreshold;
	[Export ("removalInteractionVelocityThreshold")]
	nfloat RemovalInteractionVelocityThreshold { get; }
}

// @protocol FloatingPanelLayout
/*
  Check whether adding [Model] to this declaration is appropriate.
  [Model] is used to generate a C# class that implements this protocol,
  and might be useful for protocols that consumers are supposed to implement,
  since consumers can subclass the generated class instead of implementing
  the generated interface. If consumers are not supposed to implement this
  protocol, then [Model] is redundant and will generate code that will never
  be used.
*/


[Protocol, Model (Name = "_TtP13FloatingPanel19FloatingPanelLayout_")]
[BaseType (typeof(NSObject))]
interface FloatingPanelLayout 
{
	// @required @property (readonly, nonatomic) enum FloatingPanelPosition position;
	[Abstract]
	[Export ("position")]
	FloatingPanelPosition Position { get; }

	// @required @property (readonly, nonatomic, strong) FloatingPanelState * _Nonnull initialState;
	[Abstract]
	[Export ("initialState", ArgumentSemantic.Strong)]
	FloatingPanelState InitialState { get; }

	// @required @property (readonly, copy, nonatomic) NSDictionary<FloatingPanelState *,id<FloatingPanelLayoutAnchoring>> * _Nonnull anchors;
	[Abstract]
	[Export ("anchors", ArgumentSemantic.Copy)]
	NSDictionary<FloatingPanelState, FloatingPanelLayoutAnchoring> Anchors { get; }

	// @optional -(NSArray<NSLayoutConstraint *> * _Nonnull)prepareLayoutWithSurfaceView:(UIView * _Nonnull)surfaceView in:(UIView * _Nonnull)view __attribute__((warn_unused_result("")));
	[Export ("prepareLayoutWithSurfaceView:in:")]
	NSLayoutConstraint[] PrepareLayoutWithSurfaceView (UIView surfaceView, UIView view);

	// @optional -(CGFloat)backdropAlphaFor:(FloatingPanelState * _Nonnull)state __attribute__((warn_unused_result("")));
	[Export ("backdropAlphaFor:")]
	nfloat BackdropAlphaFor (FloatingPanelState state);
}

// @interface FloatingPanelBottomLayout : NSObject <FloatingPanelLayout>
[BaseType (typeof(NSObject), Name = "_TtC13FloatingPanel25FloatingPanelBottomLayout")]
interface FloatingPanelBottomLayout : FloatingPanelLayout
{
	// @property (readonly, nonatomic, strong) FloatingPanelState * _Nonnull initialState;
	[Export ("initialState", ArgumentSemantic.Strong)]
	FloatingPanelState InitialState { get; }

	// @property (readonly, copy, nonatomic) NSDictionary<FloatingPanelState *,id<FloatingPanelLayoutAnchoring>> * _Nonnull anchors;
	[Export ("anchors", ArgumentSemantic.Copy)]
	NSDictionary<FloatingPanelState, FloatingPanelLayoutAnchoring> Anchors { get; }

	// @property (readonly, nonatomic) enum FloatingPanelPosition position;
	[Export ("position")]
	FloatingPanelPosition Position { get; }

	// -(NSArray<NSLayoutConstraint *> * _Nonnull)prepareLayoutWithSurfaceView:(UIView * _Nonnull)surfaceView in:(UIView * _Nonnull)view __attribute__((warn_unused_result("")));
	[Export ("prepareLayoutWithSurfaceView:in:")]
	NSLayoutConstraint[] PrepareLayoutWithSurfaceView (UIView surfaceView, UIView view);

	// -(CGFloat)backdropAlphaFor:(FloatingPanelState * _Nonnull)state __attribute__((warn_unused_result("")));
	[Export ("backdropAlphaFor:")]
	nfloat BackdropAlphaFor (FloatingPanelState state);
}

// @interface FloatingPanelController : UIViewController
[BaseType (typeof(UIViewController), Name = "_TtC13FloatingPanel23FloatingPanelController")]
interface FloatingPanelController
{
	[Wrap ("WeakDelegate")]
	[NullAllowed]
	FloatingPanelControllerDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<IFloatingPanelControllerDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }

	// @property (readonly, nonatomic, strong) FloatingPanelSurfaceView * _Nonnull surfaceView;
	[Export ("surfaceView", ArgumentSemantic.Strong)]
	FloatingPanelSurfaceView SurfaceView { get; }

	// @property (nonatomic, strong) FloatingPanelBackdropView * _Nonnull backdropView;
	[Export ("backdropView", ArgumentSemantic.Strong)]
	FloatingPanelBackdropView BackdropView { get; set; }

	// @property (readonly, nonatomic, weak) UIScrollView * _Nullable trackingScrollView;
	[NullAllowed, Export ("trackingScrollView", ArgumentSemantic.Weak)]
	UIScrollView TrackingScrollView { get; }

	// @property (readonly, nonatomic, strong) FloatingPanelPanGestureRecognizer * _Nonnull panGestureRecognizer;
	[Export ("panGestureRecognizer", ArgumentSemantic.Strong)]
	FloatingPanelPanGestureRecognizer PanGestureRecognizer { get; }

	// @property (readonly, nonatomic, strong) FloatingPanelState * _Nonnull state;
	[Export ("state", ArgumentSemantic.Strong)]
	FloatingPanelState State { get; }

	// @property (readonly, nonatomic) BOOL isAttracting;
	[Export ("isAttracting")]
	bool IsAttracting { get; }

	// @property (nonatomic, strong) id<FloatingPanelLayout> _Nonnull layout;
	[Export ("layout", ArgumentSemantic.Strong)]
	FloatingPanelLayout Layout { get; set; }

	// @property (nonatomic, strong) id<FloatingPanelBehavior> _Nonnull behavior;
	[Export ("behavior", ArgumentSemantic.Strong)]
	FloatingPanelBehavior Behavior { get; set; }

	// @property (readonly, nonatomic) UIEdgeInsets adjustedContentInsets;
	[Export ("adjustedContentInsets")]
	UIEdgeInsets AdjustedContentInsets { get; }

	// @property (nonatomic) enum ContentInsetAdjustmentBehavior contentInsetAdjustmentBehavior;
	[Export ("contentInsetAdjustmentBehavior", ArgumentSemantic.Assign)]
	ContentInsetAdjustmentBehavior ContentInsetAdjustmentBehavior { get; set; }

	// @property (nonatomic, setter = setRemovalInteractionEnabled:) BOOL isRemovalInteractionEnabled;
	[Export ("isRemovalInteractionEnabled")]
	bool IsRemovalInteractionEnabled { get; [Bind ("setRemovalInteractionEnabled:")] set; }

	// @property (nonatomic, strong) UIViewController * _Nullable contentViewController;
	[NullAllowed, Export ("contentViewController", ArgumentSemantic.Strong)]
	UIViewController ContentViewController { get; set; }

	// @property (nonatomic) enum ContentMode contentMode;
	[Export ("contentMode", ArgumentSemantic.Assign)]
	ContentMode ContentMode { get; set; }
	

	// -(instancetype _Nonnull)initWithNibName:(NSString * _Nullable)nibNameOrNil bundle:(NSBundle * _Nullable)nibBundleOrNil __attribute__((objc_designated_initializer));
	[Export ("initWithNibName:bundle:")]
	[DesignatedInitializer]
	NativeHandle Constructor ([NullAllowed] string nibNameOrNil, [NullAllowed] NSBundle nibBundleOrNil);

	// -(instancetype _Nonnull)initWithDelegate:(id<IFloatingPanelControllerDelegate> _Nullable)delegate __attribute__((objc_designated_initializer));
	[Export ("initWithDelegate:")]
	[DesignatedInitializer]
	NativeHandle Constructor ([NullAllowed] FloatingPanelControllerDelegate @delegate);

	// -(void)loadView;
	[Export ("loadView")]
	void LoadView ();

	// -(void)viewDidLayoutSubviews;
	[Export ("viewDidLayoutSubviews")]
	void ViewDidLayoutSubviews ();

	// -(void)viewDidAppear:(BOOL)animated;
	[Export ("viewDidAppear:")]
	void ViewDidAppear (bool animated);

	// -(void)viewWillTransitionToSize:(CGSize)size withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
	[Export ("viewWillTransitionToSize:withTransitionCoordinator:")]
	void ViewWillTransitionToSize (CGSize size, IUIViewControllerTransitionCoordinator coordinator);

	// -(void)willTransitionToTraitCollection:(UITraitCollection * _Nonnull)newCollection withTransitionCoordinator:(id<UIViewControllerTransitionCoordinator> _Nonnull)coordinator;
	[Export ("willTransitionToTraitCollection:withTransitionCoordinator:")]
	void WillTransitionToTraitCollection (UITraitCollection newCollection, IUIViewControllerTransitionCoordinator coordinator);

	// -(void)viewWillDisappear:(BOOL)animated;
	[Export ("viewWillDisappear:")]
	void ViewWillDisappear (bool animated);

	// @property (readonly, nonatomic, strong) UIViewController * _Nullable childViewControllerForStatusBarStyle;
	[NullAllowed, Export ("childViewControllerForStatusBarStyle", ArgumentSemantic.Strong)]
	UIViewController ChildViewControllerForStatusBarStyle { get; }

	// @property (readonly, nonatomic, strong) UIViewController * _Nullable childViewControllerForStatusBarHidden;
	[NullAllowed, Export ("childViewControllerForStatusBarHidden", ArgumentSemantic.Strong)]
	UIViewController ChildViewControllerForStatusBarHidden { get; }

	// @property (readonly, nonatomic, strong) UIViewController * _Nullable childViewControllerForScreenEdgesDeferringSystemGestures;
	[NullAllowed, Export ("childViewControllerForScreenEdgesDeferringSystemGestures", ArgumentSemantic.Strong)]
	UIViewController ChildViewControllerForScreenEdgesDeferringSystemGestures { get; }

	// @property (readonly, nonatomic, strong) UIViewController * _Nullable childViewControllerForHomeIndicatorAutoHidden;
	[NullAllowed, Export ("childViewControllerForHomeIndicatorAutoHidden", ArgumentSemantic.Strong)]
	UIViewController ChildViewControllerForHomeIndicatorAutoHidden { get; }

	// -(void)show:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
	[Export ("show:completion:")]
	void Show (bool animated, [NullAllowed] Action completion);

	// -(void)hide:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
	[Export ("hide:completion:")]
	void Hide (bool animated, [NullAllowed] Action completion);

	// -(void)addPanelToParent:(UIViewController * _Nonnull)parent at:(NSInteger)viewIndex animated:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
	[Export ("addPanelToParent:at:animated:completion:")]
	void AddPanelToParent (UIViewController parent, nint viewIndex = -1, bool animated = false, [NullAllowed] Action completion = null);

	// -(void)removePanelFromParent:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
	[Export ("removePanelFromParent:completion:")]
	void RemovePanelFromParent (bool animated, [NullAllowed] Action completion);

	// -(void)moveToState:(FloatingPanelState * _Nonnull)to animated:(BOOL)animated completion:(void (^ _Nullable)(void))completion;
	[Export ("moveToState:animated:completion:")]
	void MoveToState (FloatingPanelState to, bool animated, [NullAllowed] Action completion);

	// -(void)trackScrollView:(UIScrollView * _Nonnull)scrollView;
	[Export ("trackScrollView:")]
	void TrackScrollView (UIScrollView scrollView);

	// -(void)untrackScrollView:(UIScrollView * _Nonnull)scrollView;
	[Export ("untrackScrollView:")]
	void UntrackScrollView (UIScrollView scrollView);

	// -(BOOL)accessibilityPerformEscape __attribute__((swift_attr("@UIActor"))) __attribute__((warn_unused_result("")));
	[Export ("accessibilityPerformEscape")]
	bool AccessibilityPerformEscape { get; }

	// -(void)invalidateLayout;
	[Export ("invalidateLayout")]
	void InvalidateLayout ();

	// -(CGPoint)surfaceLocationFor:(FloatingPanelState * _Nonnull)state __attribute__((warn_unused_result("")));
	[Export ("surfaceLocationFor:")]
	CGPoint SurfaceLocationFor (FloatingPanelState state);

	// @property (nonatomic) CGPoint surfaceLocation;
	[Export ("surfaceLocation", ArgumentSemantic.Assign)]
	CGPoint SurfaceLocation { get; set; }
}

// @protocol IFloatingPanelControllerDelegate
[Protocol (Name = "_TtP13FloatingPanel31IFloatingPanelControllerDelegate_"), Model]
	[BaseType (typeof(NSObject))]
interface FloatingPanelControllerDelegate
{
	// @optional -(id<FloatingPanelLayout> _Nonnull)floatingPanel:(FloatingPanelController * _Nonnull)fpc layoutForTraitCollection:(UITraitCollection * _Nonnull)newCollection __attribute__((warn_unused_result("")));
	[Export ("floatingPanel:layoutForTraitCollection:")]
	FloatingPanelLayout FloatingPanel (FloatingPanelController fpc, UITraitCollection newCollection);

	// @optional -(id<FloatingPanelLayout> _Nonnull)floatingPanel:(FloatingPanelController * _Nonnull)fpc layoutForSize:(CGSize)size __attribute__((warn_unused_result("")));
	[Export ("floatingPanel:layoutForSize:")]
	FloatingPanelLayout FloatingPanel (FloatingPanelController fpc, CGSize size);

	// @optional -(UIViewPropertyAnimator * _Nonnull)floatingPanel:(FloatingPanelController * _Nonnull)fpc animatorForPresentingToState:(FloatingPanelState * _Nonnull)state __attribute__((warn_unused_result("")));
	[Export ("floatingPanel:animatorForPresentingToState:")]
	UIViewPropertyAnimator FloatingPanel (FloatingPanelController fpc, FloatingPanelState state);

	// @optional -(UIViewPropertyAnimator * _Nonnull)floatingPanel:(FloatingPanelController * _Nonnull)fpc animatorForDismissingWithVelocity:(CGVector)velocity __attribute__((warn_unused_result("")));
	[Export ("floatingPanel:animatorForDismissingWithVelocity:")]
	UIViewPropertyAnimator FloatingPanel (FloatingPanelController fpc, CGVector velocity);

	// @optional -(void)floatingPanelDidChangeState:(FloatingPanelController * _Nonnull)fpc;
	[Export ("floatingPanelDidChangeState:")]
	void FloatingPanelDidChangeState (FloatingPanelController fpc);

	// @optional -(BOOL)floatingPanelShouldBeginDragging:(FloatingPanelController * _Nonnull)fpc __attribute__((warn_unused_result("")));
	[Export ("floatingPanelShouldBeginDragging:")]
	bool FloatingPanelShouldBeginDragging (FloatingPanelController fpc);

	// @optional -(void)floatingPanelDidMove:(FloatingPanelController * _Nonnull)fpc;
	[Export ("floatingPanelDidMove:")]
	void FloatingPanelDidMove (FloatingPanelController fpc);

	// @optional -(void)floatingPanelWillBeginDragging:(FloatingPanelController * _Nonnull)fpc;
	[Export ("floatingPanelWillBeginDragging:")]
	void FloatingPanelWillBeginDragging (FloatingPanelController fpc);

	// @optional -(void)floatingPanelWillEndDragging:(FloatingPanelController * _Nonnull)fpc withVelocity:(CGPoint)velocity targetState:(FloatingPanelState * _Nonnull * _Nonnull)targetState;
	[Export ("floatingPanelWillEndDragging:withVelocity:targetState:")]
	void FloatingPanelWillEndDragging (FloatingPanelController fpc, CGPoint velocity, out FloatingPanelState targetState);

	// @optional -(void)floatingPanelDidEndDragging:(FloatingPanelController * _Nonnull)fpc willAttract:(BOOL)attract;
	[Export ("floatingPanelDidEndDragging:willAttract:")]
	void FloatingPanelDidEndDragging (FloatingPanelController fpc, bool attract);

	// @optional -(void)floatingPanelWillBeginAttracting:(FloatingPanelController * _Nonnull)fpc to:(FloatingPanelState * _Nonnull)state;
	[Export ("floatingPanelWillBeginAttracting:to:")]
	void FloatingPanelWillBeginAttracting (FloatingPanelController fpc, FloatingPanelState state);

	// @optional -(void)floatingPanelDidEndAttracting:(FloatingPanelController * _Nonnull)fpc;
	[Export ("floatingPanelDidEndAttracting:")]
	void FloatingPanelDidEndAttracting (FloatingPanelController fpc);

	// @optional -(BOOL)floatingPanel:(FloatingPanelController * _Nonnull)fpc shouldRemoveAtLocation:(CGPoint)location withVelocity:(CGVector)velocity __attribute__((warn_unused_result("")));
	[Export ("floatingPanel:shouldRemoveAtLocation:withVelocity:")]
	bool FloatingPanel (FloatingPanelController fpc, CGPoint location, CGVector velocity);

	// @optional -(void)floatingPanelWillRemove:(FloatingPanelController * _Nonnull)fpc;
	[Export ("floatingPanelWillRemove:")]
	void FloatingPanelWillRemove (FloatingPanelController fpc);

	// @optional -(void)floatingPanelDidRemove:(FloatingPanelController * _Nonnull)fpc;
	[Export ("floatingPanelDidRemove:")]
	void FloatingPanelDidRemove (FloatingPanelController fpc);

	// @optional -(CGPoint)floatingPanel:(FloatingPanelController * _Nonnull)fpc contentOffsetForPinningScrollView:(UIScrollView * _Nonnull)trackingScrollView __attribute__((warn_unused_result("")));
	[Export ("floatingPanel:contentOffsetForPinningScrollView:")]
	CGPoint FloatingPanel (FloatingPanelController fpc, UIScrollView trackingScrollView);

	// @optional -(BOOL)floatingPanel:(FloatingPanelController * _Nonnull)fpc shouldAllowToScroll:(UIScrollView * _Nonnull)scrollView in:(FloatingPanelState * _Nonnull)state __attribute__((warn_unused_result("")));
	[Export ("floatingPanel:shouldAllowToScroll:in:")]
	bool FloatingPanel (FloatingPanelController fpc, UIScrollView scrollView, FloatingPanelState state);
}

// @interface FloatingPanelIntrinsicLayoutAnchor : NSObject <FloatingPanelLayoutAnchoring>
[BaseType (typeof(NSObject), Name = "_TtC13FloatingPanel34FloatingPanelIntrinsicLayoutAnchor")]
[DisableDefaultCtor]
interface FloatingPanelIntrinsicLayoutAnchor : FloatingPanelLayoutAnchoring
{
	// -(instancetype _Nonnull)initWithAbsoluteOffset:(CGFloat)absoluteOffset referenceGuide:(enum FloatingPanelLayoutReferenceGuide)referenceGuide __attribute__((objc_designated_initializer));
	[Export ("initWithAbsoluteOffset:referenceGuide:")]
	[DesignatedInitializer]
	NativeHandle InitWithAbsoluteOffset (nfloat absoluteOffset, FloatingPanelLayoutReferenceGuide referenceGuide);

	// -(instancetype _Nonnull)initWithFractionalOffset:(CGFloat)fractionalOffset referenceGuide:(enum FloatingPanelLayoutReferenceGuide)referenceGuide __attribute__((objc_designated_initializer));
	[Export ("initWithFractionalOffset:referenceGuide:")]
	[DesignatedInitializer]
	NativeHandle InitWithFractionalOffset (nfloat fractionalOffset, FloatingPanelLayoutReferenceGuide referenceGuide);

	// @property (readonly, nonatomic) enum FloatingPanelLayoutReferenceGuide referenceGuide;
	[Export ("referenceGuide")]
	FloatingPanelLayoutReferenceGuide ReferenceGuide { get; }
}

// @interface FloatingPanel_Swift_703 (FloatingPanelIntrinsicLayoutAnchor)
[Category]
[BaseType (typeof(FloatingPanelIntrinsicLayoutAnchor))]
interface FloatingPanelIntrinsicLayoutAnchor_FloatingPanel_Swift_703
{
	// -(NSArray<NSLayoutConstraint *> * _Nonnull)layoutConstraints:(FloatingPanelController * _Nonnull)vc for:(enum FloatingPanelPosition)position __attribute__((warn_unused_result("")));
	[Export ("layoutConstraints:for:")]
	NSLayoutConstraint[] LayoutConstraints (FloatingPanelController vc, FloatingPanelPosition position);
}

// @interface FloatingPanelLayoutAnchor : NSObject <FloatingPanelLayoutAnchoring>
[BaseType (typeof(NSObject), Name = "_TtC13FloatingPanel25FloatingPanelLayoutAnchor")]
[DisableDefaultCtor]
interface FloatingPanelLayoutAnchor : FloatingPanelLayoutAnchoring
{
	// -(instancetype _Nonnull)initWithAbsoluteInset:(CGFloat)absoluteInset edge:(enum FloatingPanelReferenceEdge)edge referenceGuide:(enum FloatingPanelLayoutReferenceGuide)referenceGuide __attribute__((objc_designated_initializer));
	[Export ("initWithAbsoluteInset:edge:referenceGuide:")]
	[DesignatedInitializer]
	NativeHandle initWithAbsoluteInset (nfloat absoluteInset, FloatingPanelReferenceEdge edge, FloatingPanelLayoutReferenceGuide referenceGuide);

	// -(instancetype _Nonnull)initWithFractionalInset:(CGFloat)fractionalInset edge:(enum FloatingPanelReferenceEdge)edge referenceGuide:(enum FloatingPanelLayoutReferenceGuide)referenceGuide __attribute__((objc_designated_initializer));
	[Export ("initWithFractionalInset:edge:referenceGuide:")]
	[DesignatedInitializer]
	NativeHandle initWithFractionalInset (nfloat fractionalInset, FloatingPanelReferenceEdge edge, FloatingPanelLayoutReferenceGuide referenceGuide);

	// @property (readonly, nonatomic) enum FloatingPanelLayoutReferenceGuide referenceGuide;
	[Export ("referenceGuide")]
	FloatingPanelLayoutReferenceGuide ReferenceGuide { get; }

	// @property (readonly, nonatomic) enum FloatingPanelReferenceEdge referenceEdge;
	[Export ("referenceEdge")]
	FloatingPanelReferenceEdge ReferenceEdge { get; }
}

// @interface FloatingPanel_Swift_742 (FloatingPanelLayoutAnchor)
[Category]
[BaseType (typeof(FloatingPanelLayoutAnchor))]
interface FloatingPanelLayoutAnchor_FloatingPanel_Swift_742
{
	// -(NSArray<NSLayoutConstraint *> * _Nonnull)layoutConstraints:(FloatingPanelController * _Nonnull)vc for:(enum FloatingPanelPosition)position __attribute__((warn_unused_result("")));
	[Export ("layoutConstraints:for:")]
	NSLayoutConstraint[] LayoutConstraints (FloatingPanelController vc, FloatingPanelPosition position);
}

// @interface FloatingPanelPanGestureRecognizer : UIPanGestureRecognizer
[BaseType (typeof(UIPanGestureRecognizer), Name = "_TtC13FloatingPanel33FloatingPanelPanGestureRecognizer")]
interface FloatingPanelPanGestureRecognizer
{
	// -(void)touchesBegan:(NSSet<UITouch *> * _Nonnull)touches withEvent:(UIEvent * _Nonnull)event;
	[Export ("touchesBegan:withEvent:")]
	void TouchesBegan (NSSet<UITouch> touches, UIEvent @event);

	[Wrap ("WeakDelegate")]
	[NullAllowed]
	UIGestureRecognizerDelegate Delegate { get; set; }

	// @property (nonatomic, weak) id<UIGestureRecognizerDelegate> _Nullable delegate;
	[NullAllowed, Export ("delegate", ArgumentSemantic.Weak)]
	NSObject WeakDelegate { get; set; }
}

// @interface FloatingPanelState : NSObject <NSCopying>
[BaseType (typeof(NSObject), Name = "_TtC13FloatingPanel18FloatingPanelState")]
[DisableDefaultCtor]
interface FloatingPanelState : INSCopying
{
	// -(instancetype _Nonnull)initWithRawValue:(NSString * _Nonnull)rawValue order:(NSInteger)order __attribute__((objc_designated_initializer));
	[Export ("initWithRawValue:order:")]
	[DesignatedInitializer]
	NativeHandle Constructor (string rawValue, nint order);
	

	// @property (readonly, copy, nonatomic) NSString * _Nonnull description;
	[Export ("description")]
	string Description { get; }

	// @property (readonly, copy, nonatomic) NSString * _Nonnull debugDescription;
	[Export ("debugDescription")]
	string DebugDescription { get; }

	// @property (readonly, nonatomic, strong, class) FloatingPanelState * _Nonnull Full;
	[Static]
	[Export ("Full", ArgumentSemantic.Strong)]
	FloatingPanelState Full { get; }

	// @property (readonly, nonatomic, strong, class) FloatingPanelState * _Nonnull Half;
	[Static]
	[Export ("Half", ArgumentSemantic.Strong)]
	FloatingPanelState Half { get; }

	// @property (readonly, nonatomic, strong, class) FloatingPanelState * _Nonnull Tip;
	[Static]
	[Export ("Tip", ArgumentSemantic.Strong)]
	FloatingPanelState Tip { get; }

	// @property (readonly, nonatomic, strong, class) FloatingPanelState * _Nonnull Hidden;
	[Static]
	[Export ("Hidden", ArgumentSemantic.Strong)]
	FloatingPanelState Hidden { get; }
}

// @interface FloatingPanelGrabberView : UIView
[BaseType (typeof(UIView))]
interface FloatingPanelGrabberView
{
	
}

// @interface ModalDismissTransition : NSObject <UIViewControllerAnimatedTransitioning>
//[BaseType (typeof(NSObject), Name = "_TtC13FloatingPanel22ModalDismissTransition")]
/*
[BaseType (typeof(NSObject), Name = "ModalDismissTransition")]
interface ModalDismissTransition : IUIViewControllerAnimatedTransitioning
{
	// -(NSTimeInterval)transitionDuration:(id<UIViewControllerContextTransitioning> _Nullable)transitionContext __attribute__((warn_unused_result("")));
	[Export ("transitionDuration:")]
	double TransitionDuration ([NullAllowed] IUIViewControllerContextTransitioning transitionContext);

	// -(id<UIViewImplicitlyAnimating> _Nonnull)interruptibleAnimatorForTransition:(id<UIViewControllerContextTransitioning> _Nonnull)transitionContext __attribute__((warn_unused_result("")));
	[Export ("interruptibleAnimatorForTransition:")]
	IUIViewImplicitlyAnimating InterruptibleAnimatorForTransition (IUIViewControllerContextTransitioning transitionContext);

	// -(void)animateTransition:(id<UIViewControllerContextTransitioning> _Nonnull)transitionContext;
	[Export ("animateTransition:")]
	void AnimateTransition (IUIViewControllerContextTransitioning transitionContext);
}

// @interface ModalPresentTransition : NSObject <UIViewControllerAnimatedTransitioning>
//[BaseType (typeof(NSObject), Name = "_TtC13FloatingPanel22ModalPresentTransition")]
[BaseType (typeof(NSObject), Name = "ModalPresentTransition")]
interface ModalPresentTransition : IUIViewControllerAnimatedTransitioning
{
	// -(NSTimeInterval)transitionDuration:(id<UIViewControllerContextTransitioning> _Nullable)transitionContext __attribute__((warn_unused_result("")));
	[Export ("transitionDuration:")]
	double TransitionDuration ([NullAllowed] IUIViewControllerContextTransitioning transitionContext);

	// -(id<UIViewImplicitlyAnimating> _Nonnull)interruptibleAnimatorForTransition:(id<UIViewControllerContextTransitioning> _Nonnull)transitionContext __attribute__((warn_unused_result("")));
	[Export ("interruptibleAnimatorForTransition:")]
	IUIViewImplicitlyAnimating InterruptibleAnimatorForTransition (IUIViewControllerContextTransitioning transitionContext);

	// -(void)animateTransition:(id<UIViewControllerContextTransitioning> _Nonnull)transitionContext;
	[Export ("animateTransition:")]
	void AnimateTransition (IUIViewControllerContextTransitioning transitionContext);
}
*/

// @interface ModalTransition : NSObject <UIViewControllerTransitioningDelegate>
//[BaseType (typeof(NSObject), Name = "_TtC13FloatingPanel15ModalTransition")]
/*
[BaseType (typeof(NSObject), Name = "ModalTransition")]
interface ModalTransition : IUIViewControllerTransitioningDelegate
{
	// -(id<UIViewControllerAnimatedTransitioning> _Nullable)animationControllerForPresentedController:(UIViewController * _Nonnull)presented presentingController:(UIViewController * _Nonnull)presenting sourceController:(UIViewController * _Nonnull)source __attribute__((warn_unused_result("")));
	[Export ("animationControllerForPresentedController:presentingController:sourceController:")]
	[return: NullAllowed]
	UIViewControllerAnimatedTransitioning AnimationControllerForPresentedController (UIViewController presented, UIViewController presenting, UIViewController source);

	// -(id<UIViewControllerAnimatedTransitioning> _Nullable)animationControllerForDismissedController:(UIViewController * _Nonnull)dismissed __attribute__((warn_unused_result("")));
	[Export ("animationControllerForDismissedController:")]
	[return: NullAllowed]
	UIViewControllerAnimatedTransitioning AnimationControllerForDismissedController (UIViewController dismissed);

	// -(UIPresentationController * _Nullable)presentationControllerForPresentedViewController:(UIViewController * _Nonnull)presented presentingViewController:(UIViewController * _Nullable)presenting sourceViewController:(UIViewController * _Nonnull)source __attribute__((warn_unused_result("")));
	[Export ("presentationControllerForPresentedViewController:presentingViewController:sourceViewController:")]
	[return: NullAllowed]
	UIPresentationController PresentationControllerForPresentedViewController (UIViewController presented, [NullAllowed] UIViewController presenting, UIViewController source);
}
*/

// @interface FloatingPanelPassthroughView : UIView
[BaseType(typeof(UIView), Name = "FloatingPanelPassthroughView")]
interface FloatingPanelPassthroughView
{
}

/*
// @interface PresentationController : UIPresentationController
//[BaseType (typeof(UIPresentationController), Name = "_TtC13FloatingPanel22PresentationController")]
[BaseType (typeof(UIPresentationController), Name = "PresentationController")]
interface PresentationController
{
	// -(void)presentationTransitionWillBegin;
	[Export ("presentationTransitionWillBegin")]
	void PresentationTransitionWillBegin ();

	// -(void)presentationTransitionDidEnd:(BOOL)completed;
	[Export ("presentationTransitionDidEnd:")]
	void PresentationTransitionDidEnd (bool completed);

	// -(void)dismissalTransitionDidEnd:(BOOL)completed;
	[Export ("dismissalTransitionDidEnd:")]
	void DismissalTransitionDidEnd (bool completed);

	// -(void)containerViewWillLayoutSubviews;
	[Export ("containerViewWillLayoutSubviews")]
	void ContainerViewWillLayoutSubviews ();

	// -(void)handleBackdropWithTapGesture:(UITapGestureRecognizer * _Nonnull)tapGesture;
	[Export ("handleBackdropWithTapGesture:")]
	void HandleBackdropWithTapGesture (UITapGestureRecognizer tapGesture);

	// -(instancetype _Nonnull)initWithPresentedViewController:(UIViewController * _Nonnull)presentedViewController presentingViewController:(UIViewController * _Nullable)presentingViewController __attribute__((objc_designated_initializer));
	[Export ("initWithPresentedViewController:presentingViewController:")]
	[DesignatedInitializer]
	NativeHandle Constructor (UIViewController presentedViewController, [NullAllowed] UIViewController presentingViewController);
}
*/

// @interface FloatingPanelSurfaceView : UIView
[BaseType (typeof(UIView))]
interface FloatingPanelSurfaceView
{
	// @property (readonly, nonatomic, strong) FloatingPanelGrabberView * _Nonnull grabberHandle;
	[Export ("grabberHandle", ArgumentSemantic.Strong)]
	FloatingPanelGrabberView GrabberHandle { get; }

	// @property (nonatomic) CGFloat grabberHandlePadding;
	[Export ("grabberHandlePadding")]
	nfloat GrabberHandlePadding { get; set; }

	// @property (nonatomic) CGFloat grabberAreaOffset;
	[Export ("grabberAreaOffset")]
	nfloat GrabberAreaOffset { get; set; }

	// @property (nonatomic) CGSize grabberHandleSize;
	[Export ("grabberHandleSize", ArgumentSemantic.Assign)]
	CGSize GrabberHandleSize { get; set; }

	// @property (nonatomic, weak) UIView * _Nullable contentView;
	[NullAllowed, Export ("contentView", ArgumentSemantic.Weak)]
	UIView ContentView { get; set; }

	// @property (nonatomic) UIEdgeInsets contentPadding;
	[Export ("contentPadding", ArgumentSemantic.Assign)]
	UIEdgeInsets ContentPadding { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
	[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
	UIColor BackgroundColor { get; set; }

	// @property (nonatomic, strong) FloatingPanelSurfaceAppearance * _Nonnull appearance;
	[Export ("appearance", ArgumentSemantic.Strong)]
	FloatingPanelSurfaceAppearance FloatingPanelSurfaceAppearance { get; set; }

	// @property (nonatomic) UIEdgeInsets containerMargins;
	[Export ("containerMargins", ArgumentSemantic.Assign)]
	UIEdgeInsets ContainerMargins { get; set; }

	// @property (readonly, nonatomic, strong) UIView * _Nonnull containerView;
	[Export ("containerView", ArgumentSemantic.Strong)]
	UIView ContainerView { get; }

	// @property (nonatomic) CGFloat containerOverflow;
	[Export ("containerOverflow")]
	nfloat ContainerOverflow { get; set; }

	// @property (nonatomic) enum FloatingPanelPosition position;
	[Export ("position", ArgumentSemantic.Assign)]
	FloatingPanelPosition Position { get; set; }

	// @property (readonly, nonatomic) CGRect grabberAreaFrame;
	[Export ("grabberAreaFrame")]
	CGRect GrabberAreaFrame { get; }

	// @property (readonly, nonatomic, class) BOOL requiresConstraintBasedLayout;
	[Static]
	[Export ("requiresConstraintBasedLayout")]
	bool RequiresConstraintBasedLayout { get; }

	// -(instancetype _Nonnull)initWithFrame:(CGRect)frame __attribute__((objc_designated_initializer));
	[Export ("initWithFrame:")]
	[DesignatedInitializer]
	NativeHandle Constructor (CGRect frame);

	// -(instancetype _Nullable)initWithCoder:(NSCoder * _Nonnull)aDecoder __attribute__((objc_designated_initializer));
	//[Export ("initWithCoder:")]
	//[DesignatedInitializer]
	//NativeHandle Constructor (NSCoder aDecoder);

	// -(void)updateConstraints __attribute__((objc_requires_super));
	[Export ("updateConstraints")]
	[RequiresSuper]
	void UpdateConstraints ();

	// -(void)layoutSubviews;
	[Export ("layoutSubviews")]
	void LayoutSubviews ();

	// @property (readonly, nonatomic) CGSize intrinsicContentSize;
	[Export ("intrinsicContentSize")]
	CGSize IntrinsicContentSize { get; }

	// -(void)setWithContentView:(UIView * _Nonnull)contentView mode:(enum ContentMode)mode;
	[Export ("setWithContentView:mode:")]
	void SetWithContentView (UIView contentView, ContentMode mode);

	// -(BOOL)hasStackView __attribute__((warn_unused_result("")));
	[Export ("hasStackView")]
	bool HasStackView { get; }

	// -(BOOL)grabberAreaContains:(CGPoint)location __attribute__((warn_unused_result("")));
	[Export ("grabberAreaContains:")]
	bool GrabberAreaContains (CGPoint location);
}


// @interface FloatingPanel_Swift_974 (UIViewController)
[Category]
interface UIViewController_FloatingPanel_Swift_974
{
	// @property (readonly, nonatomic) UIEdgeInsets fp_safeAreaInsets;
	[Export ("fp_safeAreaInsets")]
	UIEdgeInsets Fp_safeAreaInsets { get; }
}


// @interface FloatingPanelSurfaceAppearance : NSObject
[BaseType (typeof(NSObject))]
interface FloatingPanelSurfaceAppearance
{
	// @property (nonatomic, strong) UIColor * _Nullable backgroundColor;
	[NullAllowed, Export ("backgroundColor", ArgumentSemantic.Strong)]
	UIColor BackgroundColor { get; set; }

	// @property (nonatomic) CGFloat cornerRadius;
	[Export ("cornerRadius")]
	nfloat CornerRadius { get; set; }

	// @property (nonatomic) SWIFT_AVAILABILITY(ios,introduced=13.0) CALayerCornerCurve cornerCurve __attribute__((availability(ios, introduced=13.0)));
	[Export ("cornerCurve")]
	string CornerCurve { get; set; }

	// @property (copy, nonatomic) NSArray<FloatingPanelSurfaceAppearanceShadow *> * _Nonnull shadows;
	[Export ("shadows", ArgumentSemantic.Copy)]
	FloatingPanelSurfaceAppearanceShadow[] Shadows { get; set; }

	// @property (nonatomic, strong) UIColor * _Nullable borderColor;
	[NullAllowed, Export ("borderColor", ArgumentSemantic.Strong)]
	UIColor BorderColor { get; set; }

	// @property (nonatomic) CGFloat borderWidth;
	[Export ("borderWidth")]
	nfloat BorderWidth { get; set; }
}


// @interface FloatingPanelSurfaceAppearanceShadow : NSObject
[BaseType (typeof(NSObject))]
interface FloatingPanelSurfaceAppearanceShadow
{
	// @property (nonatomic) BOOL hidden;
	[Export ("hidden")]
	bool Hidden { get; set; }

	// @property (nonatomic, strong) UIColor * _Nonnull color;
	[Export ("color", ArgumentSemantic.Strong)]
	UIColor Color { get; set; }

	// @property (nonatomic) CGSize offset;
	[Export ("offset", ArgumentSemantic.Assign)]
	CGSize Offset { get; set; }

	// @property (nonatomic) float opacity;
	[Export ("opacity")]
	float Opacity { get; set; }

	// @property (nonatomic) CGFloat radius;
	[Export ("radius")]
	nfloat Radius { get; set; }

	// @property (nonatomic) CGFloat spread;
	[Export ("spread")]
	nfloat Spread { get; set; }
}
