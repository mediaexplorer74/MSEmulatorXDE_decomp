﻿using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Threading.Tasks;
using Windows.Services.Store;

namespace Microsoft.Xde.DeviceManagement
{
    internal class StoreQueueItem
    {
        internal EventRegistrationToken add_Completed(TypedEventHandler<StoreQueueItem, StoreQueueItemCompletedEventArgs> arg)
        {
            throw new NotImplementedException();
        }

        internal EventRegistrationToken add_StatusChanged(TypedEventHandler<StoreQueueItem, object> arg)
        {
            throw new NotImplementedException();
        }

        internal Task CancelInstallAsync()
        {
            throw new NotImplementedException();
        }

        internal StoreQueueItemStatus GetCurrentStatus()
        {
            throw new NotImplementedException();
        }

        internal void remove_Completed(EventRegistrationToken obj)
        {
            throw new NotImplementedException();
        }

        internal void remove_StatusChanged(EventRegistrationToken obj)
        {
            throw new NotImplementedException();
        }

        public static implicit operator StoreQueueItem(int v)
        {
            throw new NotImplementedException();
        }
    }


    // Token: 0x02000005 RID: 5
    internal class StoreQueueItemStatusWrapper : IDownloadableItemStatus
	{
		// Token: 0x0600002E RID: 46 RVA: 0x00002684 File Offset: 0x00000884
		public StoreQueueItemStatusWrapper(StoreQueueItemStatus status)
		{
			this.status = status;
		}

		// Token: 0x17000019 RID: 25
		// (get) Token: 0x0600002F RID: 47 RVA: 0x00002693 File Offset: 0x00000893
		public Exception ExtendedError
		{
			get
			{
				return this.status.ExtendedError;
			}
		}

		// Token: 0x1700001A RID: 26
		// (get) Token: 0x06000030 RID: 48 RVA: 0x000026A0 File Offset: 0x000008A0
		public StoreQueueItemState PackageInstallState
		{
			get
			{
				return this.status.PackageInstallState;
			}
		}

		// Token: 0x1700001B RID: 27
		// (get) Token: 0x06000031 RID: 49 RVA: 0x000026AD File Offset: 0x000008AD
		public StorePackageUpdateStatus UpdateStatus
		{
			get
			{
				return this.status.UpdateStatus;
			}
		}

		// Token: 0x04000012 RID: 18
		private readonly StoreQueueItemStatus status;
	}
}
