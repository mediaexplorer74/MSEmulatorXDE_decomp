using Microsoft.Xde.Common;

namespace Microsoft.Xde.Client
{
    public interface IXdeSensorConfig
    {
        XdeSensors EnabledStates { get; }
    }
}