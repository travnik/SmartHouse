using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SmartHouse.DomainModel;
using SmartHouse.DomainModel.SmartDevices.Common;
using SmartHouse.Presentation.Common;
using SmartHouse.Presentation.Views;
using SmartHouse.Presentation.Views.ViewModels;

namespace SmartHouse.Presentation.Presenters
{
    public class ScenarioPresenter : BasePresener<IScenarioView>
    {
        private readonly IScenarioModel _scenarioModel;

        public ScenarioPresenter(IApplicationController controller, 
            IScenarioView view,
            IScenarioModel scenarioModel) 
            : base(controller, view)
        {
            _scenarioModel = scenarioModel;
            view.DeviceSelected += ViewOnDeviceSelected;
            view.AddCommand += AddCommand;
            View.BindScript(_scenarioModel.DescriptCommands);
            AddDevicesToView();
        }

        private void AddCommand(DescriptCommand command)
        {
            _scenarioModel.AddCommand(command);
        }

        private void ViewOnDeviceSelected(DeviceViewModel deviceModel)
        {
            var device = _scenarioModel.GetDevice(deviceModel.Id);
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

            View.BindCommandsList(commands);
        }

        private void AddDevicesToView()
        {
            var devices = _scenarioModel.GetDevices()
                .Select(o => new DeviceViewModel()
                {
                    Id = o.Id,
                    Name = o.Name
                })
                .ToList();
            View.BindDevicesList(devices);
        }
    }
}
