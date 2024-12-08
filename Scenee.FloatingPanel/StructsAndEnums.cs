using ObjCRuntime;

namespace Scenee.FloatingPanel;

[Native]
public enum ContentInsetAdjustmentBehavior : long
{
	Always = 0,
	Never = 1
}

[Native]
public enum ContentMode : long
{
	Static = 0,
	FitToBounds = 1
}

[Native]
public enum FloatingPanelLayoutContentBoundingGuide : long
{
	None = 0,
	Superview = 1,
	SafeArea = 2
}

[Native]
public enum FloatingPanelLayoutReferenceGuide : long
{
	uperview = 0,
	afeArea = 1
}

[Native]
public enum FloatingPanelPosition : long
{
	Top = 0,
	Left = 1,
	Bottom = 2,
	Right = 3
}

[Native]
public enum FloatingPanelReferenceEdge : long
{
	Top = 0,
	Left = 1,
	Bottom = 2,
	Right = 3
}
