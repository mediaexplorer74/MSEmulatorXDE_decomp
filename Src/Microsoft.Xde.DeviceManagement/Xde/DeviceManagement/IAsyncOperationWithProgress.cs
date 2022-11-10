using System;

namespace Microsoft.Xde.DeviceManagement
{
    internal interface IAsyncOperationWithProgress<T1, T2>
    {
        object Status { get; }
        Exception ErrorCode { get; }

        StorePackageUpdateResult GetResults();
        void put_Progress(Action<IAsyncOperationWithProgress<StorePackageUpdateResult, StorePackageUpdateStatus>, StorePackageUpdateStatus> value);
    }
}