using System;

namespace Microsoft.Xde.DeviceManagement
{
    public class StoreQueueItemStatus
    {
        public int PackageInstallState { get; internal set; }
        public Exception ExtendedError { get; internal set; }
        public StorePackageUpdateStatus UpdateStatus { get; internal set; }
    }
}