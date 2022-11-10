using System;
using System.Windows;
using System.Windows.Controls;

namespace Microsoft.Xde.Client.XdeTools
{
    public class XdeToolsControl : Control
    {
        public Action<object, EventArgs> CloseClicked { get; internal set; }
        public Action<object, EventArgs> StartDragMove { get; internal set; }
        public string SelectedTabId { get; internal set; }

        internal string[] GetTabIds()
        {
            throw new NotImplementedException();
        }

        internal void Initialize()
        {
            throw new NotImplementedException();
        }

        internal void InsertTab(string caption, string name, UserControl tab, int v)
        {
            throw new NotImplementedException();
        }
    }
}