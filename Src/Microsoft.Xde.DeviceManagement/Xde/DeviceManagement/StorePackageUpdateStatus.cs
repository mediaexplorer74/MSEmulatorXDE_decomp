namespace Microsoft.Xde.DeviceManagement
{
    public class StorePackageUpdateStatus
    {
        public int PackageUpdateState { get; internal set; }
        public ulong PackageDownloadSizeInBytes { get; set; }
        public double PackageBytesDownloaded { get; set; }
        public double PackageDownloadProgress { get; set; }
    }
}