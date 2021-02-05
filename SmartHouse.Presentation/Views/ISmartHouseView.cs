using System;
using SmartHouse.Presentation.Common;

namespace SmartHouse.Presentation.Views
{
    public interface ISmartHouseView : IView
    {
        ISmartDeviceView AddSmartDevice();
        event Action OpenScripts;
    }
}
