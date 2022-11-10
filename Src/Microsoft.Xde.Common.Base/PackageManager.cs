using System;
using System.Collections;
using System.Collections.Generic;
using System.IO.Packaging;
using System.Linq;
using System.Threading.Tasks;

namespace Microsoft.Xde.Common
{
    public class PackageManager
    {
        public PackageManager()
        {
        }

        public Package FindPackageForUser(string empty, object fullName)
        {
            throw new NotImplementedException();
        }

        public Task RemovePackageAsync(object fullName)
        {
            throw new NotImplementedException();
        }

        internal IQueryable<Package> FindPackagesForUser(string empty, string v)
        {
            throw new NotImplementedException();
        }
    }
}