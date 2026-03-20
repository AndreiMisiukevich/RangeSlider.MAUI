using System.Reflection;

namespace PanRangeSlider.Common
{
    internal static class MicrosoftMauiControlsVersionHelper
    {
        private static readonly Version MinMicrosoftMauiControlsVersion = new Version(10, 0, 40);
        private static Version? _currentVersion = null;



        internal static bool CanSupportsNewPanRunning()
        {
            return GetMauiVersion() >= MinMicrosoftMauiControlsVersion;
        }



        private static Version GetMauiVersion()
        {
            if (_currentVersion != null)
                return _currentVersion;
            
            var assembly = typeof(View).Assembly;
            var infoVersion = assembly
                .GetCustomAttribute<AssemblyInformationalVersionAttribute>()?
                .InformationalVersion;

            if (Version.TryParse(infoVersion?.Split('+')[0], out var version))
                return _currentVersion = version;

            return new Version(0, 0);
        }
    }
}
