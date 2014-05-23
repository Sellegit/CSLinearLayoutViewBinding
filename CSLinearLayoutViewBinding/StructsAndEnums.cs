using System;

namespace CSLinearLayoutViewBinding
{
  public enum CSLinearLayoutViewOrientation {
    Vertical,
    Horizontal
  }

  public enum CSLinearLayoutItemFillMode {
    Normal,
    Stretch
  }

  public enum CSLinearLayoutItemHorizontalAlignment {
    Left,
    Right,
    Center
  }

  public enum CSLinearLayoutItemVerticalAlignment {
    Top,
    Bottom,
    Center
  }

  public struct CSLinearLayoutItemPadding {
    float top;
    float left;
    float bottom;
    float right;
  }

}