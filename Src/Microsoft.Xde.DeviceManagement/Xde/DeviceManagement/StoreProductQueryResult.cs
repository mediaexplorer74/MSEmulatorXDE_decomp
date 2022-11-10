using Microsoft.Xde.Common;
using System.Collections.Generic;

namespace Microsoft.Xde.DeviceManagement
{
    internal class StoreProductQueryResult
    {
        public IEnumerable<KeyValuePair<string, StoreProduct>> Products { get; internal set; }
    }
}