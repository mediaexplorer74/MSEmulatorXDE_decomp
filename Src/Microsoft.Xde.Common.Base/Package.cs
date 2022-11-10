using System.Linq;

namespace Microsoft.Xde.Common
{
    public class Package
    {
        public static Package Current { get; internal set; }
        public PackageInfo Id { get; internal set; }
        public PackagePath InstalledLocation { get; internal set; }
        public IQueryable<Package> Dependencies { get; set; }
    }

    public class PackagePath
    {
        public string Path { get; internal set; }
    }
}