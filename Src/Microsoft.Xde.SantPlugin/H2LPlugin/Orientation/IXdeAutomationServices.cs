namespace Microsoft.Xde.H2LPlugin.Orientation
{
    public interface IXdeAutomationServices
    {
        void RegisterAutomationFeature<T>(OrientationFeature orientationFeature);
        void RegisterAutomationFeature<T>(SantPlugin.Orientation.OrientationFeature orientationFeature);
    }
}