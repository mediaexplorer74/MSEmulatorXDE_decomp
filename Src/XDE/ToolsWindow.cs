using Microsoft.Xde.Common;
using System.Windows;
using System.Windows.Documents;

namespace Microsoft.Xde.Client
{
    public class ToolsWindow : Window
    {
        //
        private IXdeSku sku;

        public ToolsWindow(IXdeSku sku)
        {
            this.sku = sku;
        }
    }
}