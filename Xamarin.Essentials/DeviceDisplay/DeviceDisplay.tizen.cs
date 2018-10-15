namespace Xamarin.Essentials
{
    public static partial class DeviceDisplay
    {
        static ScreenMetrics GetScreenMetrics()
        {
            // => throw new NotImplementedInReferenceAssemblyException();
            return new ScreenMetrics(0, 0, 0, ScreenOrientation.Unknown, ScreenRotation.Rotation0);
        }

        static void StartScreenMetricsListeners()
        {
            // => throw new NotImplementedInReferenceAssemblyException();
        }

        static void StopScreenMetricsListeners()
        {
            // => throw new NotImplementedInReferenceAssemblyException();
        }
    }
}
