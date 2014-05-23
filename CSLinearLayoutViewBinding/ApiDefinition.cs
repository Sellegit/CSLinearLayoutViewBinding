using System;
using System.Drawing;
using MonoTouch.ObjCRuntime;
using MonoTouch.Foundation;
using MonoTouch.UIKit;

namespace CSLinearLayoutViewBinding
{
  [BaseType (typeof (NSObject))]
  public partial interface CSLinearLayoutItem {

    [Export ("view", ArgumentSemantic.Retain)]
    UIView View { get; set; }

    [Export ("fillMode")]
    CSLinearLayoutItemFillMode FillMode { get; set; }

    [Export ("horizontalAlignment")]
    CSLinearLayoutItemHorizontalAlignment HorizontalAlignment { get; set; }

    [Export ("verticalAlignment")]
    CSLinearLayoutItemVerticalAlignment VerticalAlignment { get; set; }

    [Export ("padding", ArgumentSemantic.Assign)]
    CSLinearLayoutItemPadding Padding { get; set; }

    [Export ("userInfo", ArgumentSemantic.Assign)]
    NSDictionary UserInfo { get; set; }

    [Export ("tag")]
    int Tag { get; set; }

    [Export ("initWithView:")]
    IntPtr Constructor (UIView aView);

    [Static, Export ("layoutItemForView:")]
    CSLinearLayoutItem LayoutItemForView (UIView aView);
  }

  [BaseType (typeof (UIScrollView))]
  public partial interface CSLinearLayoutView {
    
    [Export ("initWithFrame:")]
    IntPtr Constructor (RectangleF frame);

    [Export ("items")]
    NSMutableArray Items { get; }

    [Export ("orientation")]
    CSLinearLayoutViewOrientation Orientation { get; set; }

    [Export ("layoutOffset")]
    float LayoutOffset { get; }

    [Export ("autoAdjustFrameSize")]
    bool AutoAdjustFrameSize { get; set; }

    [Export ("autoAdjustContentSize")]
    bool AutoAdjustContentSize { get; set; }

    [Export ("addItem:")]
    void AddItem (CSLinearLayoutItem linearLayoutItem);

    [Export ("removeItem:")]
    void RemoveItem (CSLinearLayoutItem linearLayoutItem);

    [Export ("removeAllItems")]
    void RemoveAllItems ();

    [Export ("insertItem:beforeItem:")]
    void InsertItemBefore (CSLinearLayoutItem newItem, CSLinearLayoutItem existingItem);

    [Export ("insertItem:afterItem:")]
    void InsertItemAfter (CSLinearLayoutItem newItem, CSLinearLayoutItem existingItem);

    [Export ("insertItem:atIndex:")]
    void InsertItemAt (CSLinearLayoutItem newItem, uint index);

    [Export ("moveItem:beforeItem:")]
    void MoveItemBefore (CSLinearLayoutItem movingItem, CSLinearLayoutItem existingItem);

    [Export ("moveItem:afterItem:")]
    void MoveItemAfter (CSLinearLayoutItem movingItem, CSLinearLayoutItem existingItem);

    [Export ("moveItem:toIndex:")]
    void MoveItemToIndex (CSLinearLayoutItem movingItem, uint index);

    [Export ("swapItem:withItem:")]
    void SwapItem (CSLinearLayoutItem firstItem, CSLinearLayoutItem secondItem);
  }



}

