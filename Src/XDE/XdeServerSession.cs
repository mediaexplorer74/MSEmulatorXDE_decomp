using System;

namespace Microsoft.Xde.Client
{
    public class XdeServerSession : IDisposable
    {
        internal static XdeServerSession ServiceHostFactory(string virtualMachineName, XdeController xdeController)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        internal void OnVmReboot()
        {
            throw new NotImplementedException();
        }
    }
}