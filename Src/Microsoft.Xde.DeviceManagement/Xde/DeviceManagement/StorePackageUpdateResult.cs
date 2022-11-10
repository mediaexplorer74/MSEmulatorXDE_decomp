using System.Collections.Generic;
using System.Linq;

namespace Microsoft.Xde.DeviceManagement
{
    internal class StorePackageUpdateResult
    {
        public int OverallState { get; internal set; }
        public IQueryable<StorePackageUpdateStatus> StorePackageUpdateStatuses { get; internal set; }
    }
}