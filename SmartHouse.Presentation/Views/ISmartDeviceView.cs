using System;
using System.Collections.Generic;
using System.Text;
using SmartHouse.Presentation.Common;

namespace SmartHouse.Presentation.Views
{
    public interface ISmartDeviceView
    {
        IExecuteCommandView AddButton(string name);
        void AddTextStatus(string text);
    }
}
