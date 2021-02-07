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
        IEnumerable<DeviceViewModel> SourceDevicesList { set; }

        IEnumerable<DescriptCommand> SourceCommandsList { set; }

        BindingList<DescriptCommand> SourceScriptCommands { set; }

        event Action<DeviceViewModel> DeviceSelected;

        event Action<DescriptCommand> AddCommand;

        event Action<DescriptCommand> RemoveCommand;

        event Action ExecuteScript;

        event Action SaveScript;

        void AddLog(string text);

        string ScriptName { get; set; }
    }
}
