
using Android.Content;
using Android.Views;
using JetBrains.Annotations;
using Microsoft.Maui.Platform;

namespace PanRangeSlider;

sealed partial class ThumbFrameHandler
{    
	protected override LayoutViewGroup CreatePlatformView()
	{
		var viewGroup = new ThumbFrameViewGroup(Context!)
		{
			CrossPlatformLayout = VirtualView
		};
		viewGroup.SetClipChildren(false);
		return viewGroup;
	}

	sealed class ThumbFrameViewGroup : LayoutViewGroup
    {
        public ThumbFrameViewGroup([NotNull] Context context) : base(context)
        {
        }

        public override bool OnTouchEvent(MotionEvent? e)
		{
			switch (e?.ActionMasked)
			{
				case MotionEventActions.Down:
					Parent?.RequestDisallowInterceptTouchEvent(true);
					break;
				case MotionEventActions.Up:
				case MotionEventActions.Cancel:
					Parent?.RequestDisallowInterceptTouchEvent(false);
					break;
			}
			return base.OnTouchEvent(e);
		}
	}
}