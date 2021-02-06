using System.ComponentModel;
using System.Linq;
using SmartHouse.DomainModel;
using SmartHouse.DomainModel.SmartDevices.Common;
using SmartHouse.Presentation.Common;
using SmartHouse.Presentation.Views;
using SmartHouse.Presentation.Views.ViewModels;

namespace SmartHouse.Presentation.Presenters
{
    public class ScenariosPresenter : BasePresener<IEditScenarioView>
    {
        private readonly IEditScenarioModel _scenarioModel;
        private readonly BindingList<DescriptCommand> _descriptCommands = new BindingList<DescriptCommand>();

        public ScenariosPresenter(IApplicationController controller, 
            IEditScenarioView view,
            IEditScenarioModel scenarioModel) 
            : base(controller, view)
        {
            _scenarioModel = scenarioModel;
            view.DeviceSelected += ViewOnDeviceSelected;
            view.AddCommand += AddCommand;
            View.BindScript(_descriptCommands);
            AddDevicesToView();
        }

        private void AddCommand(DescriptCommand command)
        {
            _descriptCommands.Add(command);
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
