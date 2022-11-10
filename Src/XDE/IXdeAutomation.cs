using Microsoft.Xde.Common;
using System.Collections.Generic;

namespace Microsoft.Xde.Client
{
    public interface IXdeAutomation
    {
        IXdeAutomationMicrophonePipe MicrophonePipe { get; }
        bool IsNetworkSimulationEnabled { get; set; }
        NetworkThrottlingSpeed NetThrottlingSpeed { get; set; }
        NetworkThrottlingSignalStrength SignalStrength { get; set; }
        IXdeSnapshotControl SnapshotControl { get; }
        IXdeSensorConfig SensorsConfig { get; set; }

        void GetEndPoint(out string hostIP, out string deviceIP);
        IEnumerable<ISkinButtonInfo> GetSkinButtonInfos();
        IEnumerable<string> GetSkinResources();
        void OnClientConnected();
    }
}