using SmartHouse.DomainModel.SmartDevices.Common;
using SmartHouse.Presentation.Views;

namespace SmartHouse.Presentation.Presenters
{
    public class SmartDevicePresenter
    {
        private readonly ISmartDeviceView _view;
        private readonly IDeviceModel _deviceModel;

        public SmartDevicePresenter(ISmartDeviceView smartDeviceView, IDeviceModel deviceModel)
        {
            _view = smartDeviceView;
            _deviceModel = deviceModel;
            _view.DisplayName = deviceModel.Name;
            AddCommandButtons(deviceModel);
        }

        private void AddCommandButtons(IDeviceModel deviceModel)
        {
            var commands = deviceModel.GetCommandsList();
            foreach (var command in commands)
            {
                AddExecuteCommandView(command);
            }
        }

        private void AddExecuteCommandView((string Id, string Name) command)
        {
            var view = _view.AddButton();
            view.DisplayName = command.Name;
            view.OnExecuteCommand += () => ExecuteCommand(command.Id);
        }

        private void ExecuteCommand(string commandId)
        {
            var status = _deviceModel.ExecuteCommand(commandId);
            _view.AddTextStatus(status);
        }
    }
}
