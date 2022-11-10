namespace Microsoft.Xde.Common
{
    public class Package
    {
        public static Package Current { get; internal set; }
        public PackageInfo Id { get; internal set; }
        public PackagePath InstalledLocation { get; internal set; }
    }

    public class PackagePath
    {
        public string Path { get; internal set; }
    }
}