using System;
using System.Collections.Generic;
using System.Text;
using SmartHouse.Presentation.Common;

namespace SmartHouse.Presentation.Views
{
    public interface ISmartDeviceView
    {
        string DisplayName { get; set; }
        IExecuteCommandView AddButton();
        void AddTextStatus(string text);
    }
}
