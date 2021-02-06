using System;
using System.Collections.Generic;
using System.ComponentModel;
using SmartHouse.DomainModel.SmartDevices.Common;
using SmartHouse.Presentation.Common;
using SmartHouse.Presentation.Views.ViewModels;

namespace SmartHouse.Presentation.Views
{
    public interface IEditScenarioView : IView
    {
        void BindDevicesList(IEnumerable<DeviceViewModel> devices);
        void BindCommandsList(IEnumerable<DescriptCommand> commands);
        void BindScript(BindingList<DescriptCommand> scriptCommands);
        event Action<DeviceViewModel> DeviceSelected;
        event Action<DescriptCommand> AddCommand;
        event Action<DescriptCommand> RemoveCommand;
        event Action ExecuteScript;
        event Action SaveScript;
        void AddLog(string text);
        string ScriptName { get; set; }
    }
}
