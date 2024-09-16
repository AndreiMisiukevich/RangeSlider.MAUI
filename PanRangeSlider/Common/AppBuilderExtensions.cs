
namespace PanRangeSlider;

public static class AppBuilderExtensions
{
    public static MauiAppBuilder UseRangeSlider(this MauiAppBuilder builder)
    {
        RangeSlider.Preserve();
        
        return builder.ConfigureMauiHandlers(handlers =>
        {
#if ANDROID
            handlers.AddHandler(typeof(ThumbFrame), typeof(ThumbFrameHandler));
#endif
        });
    }
}