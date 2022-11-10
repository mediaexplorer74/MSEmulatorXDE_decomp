using System;

namespace Microsoft.Xde.Base.Automation
{
    internal class XdeFeatureServerSession<T> where T : class
    {
        internal static IDisposable ServiceHostFactory<T>(string virtualMachineName, T implementation) where T : class
        {
            throw new NotImplementedException();
        }
    }
}