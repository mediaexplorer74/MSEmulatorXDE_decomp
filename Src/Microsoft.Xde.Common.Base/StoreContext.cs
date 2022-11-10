using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Xde.Common;

namespace Microsoft.Xde.Common
{
    public class StoreContext
    {
        internal static StoreContext GetDefault()
        {
            throw new NotImplementedException();
        }

    }

    public class StoreProduct
    {
        public string Title { get; set; }
        public string InAppOfferToken { get; set; }
        public string StoreId { get; set; }
        public bool IsInUserCollection { get; set; }

        internal static StoreProduct GetDefault()
        {
            throw new NotImplementedException();
        }

        public Task<bool> GetIsAnySkuInstalledAsync()
        {
            throw new NotImplementedException();
        }
    }
}