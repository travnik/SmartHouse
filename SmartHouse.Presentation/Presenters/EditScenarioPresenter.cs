using System;
using System.ComponentModel;
using System.Linq;
using SmartHouse.DomainModel;
using SmartHouse.DomainModel.Scripts;
using SmartHouse.DomainModel.SmartDevices.Common;
using SmartHouse.Presentation.Common;
using SmartHouse.Presentation.Views;
using SmartHouse.Presentation.Views.ViewModels;

namespace SmartHouse.Presentation.Presenters
{
    public class EditScenarioPresenter : BasePresener<IEditScenarioView, ScriptModel>, IDisposable
    {
        private readonly IEditScenarioModel _editScenarioModel;
        private readonly BindingList<DescriptCommand> _descriptCommands = new BindingList<DescriptCommand>();
        private ScriptModel _script                                                                                                                                                                                                  ;

        public EditScenarioPresenter(IApplicationController controller, 
            IEditScenarioView view,
            IEditScenarioModel scenarioModel) 
            : base(controller, view)
        {
            _editScenarioModel = scenarioModel;
            View.DeviceSelected += ViewOnDeviceSelected;
            View.AddCommand += AddCommand;
            View.RemoveCommand += RemoveCommand;
            View.SaveScript += SaveScript;
            View.ExecuteScript += ExecuteScript;

            View.SourceScriptCommands = _descriptCommands;
            AddDevicesToView();
        }

        private void ExecuteScript()
        {
            foreach (var command in _descriptCommands.ToList())
            {
                var status = _editScenarioModel.Execute(command);
                View.AddLog(status);
            }
        }

        private void SaveScript()
        {
            _script.Name = View.ScriptName;
            _editScenarioModel.Save(_script, _descriptCommands.ToList());
        }

        private void RemoveCommand(DescriptCommand command)
        {
            _descriptCommands.Remove(command);
        }

        private void AddCommand(DescriptCommand command)
        {
            _descriptCommands.Add(command);
        }

        private void ViewOnDeviceSelected(DeviceViewModel deviceModel)
        {
            var device = _editScenarioModel.GetDevice(deviceModel.Id);
            var commands = device
                .GetCommandsList()
                .Select(o => new DescriptCommand()
                {
                    DeviceId = device.Id,
                    DeviceName = device.Name,
                    CommandId = o.Id,
                    CommandName = o.Name
                })
                .ToList();

            View.SourceCommandsList = commands;
        }

        private void AddDevicesToView()
        {
            var devices = _editScenarioModel.GetDevices()
                .Select(o => new DeviceViewModel()
                {
                    Id = o.Id,
                    Name = o.Name
                })
                .ToList();
            View.SourceDevicesList = devices;
        }

        public void Dispose()
        {
            View.DeviceSelected -= ViewOnDeviceSelected;
            View.AddCommand -= AddCommand;
            View.RemoveCommand -= RemoveCommand;
            View.SaveScript -= SaveScript;
        }

        public override void Run(ScriptModel argument)
        {
            _script = argument;
            View.ScriptName = argument.Name;
            foreach (var command in _script.DescriptCommands)
            {
                _descriptCommands.Add(command);
            }
            View.Show();
        }
    }
}
