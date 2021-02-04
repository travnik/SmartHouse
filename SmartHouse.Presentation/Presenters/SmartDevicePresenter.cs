using SmartHouse.DomainModel.SmartDevices.Common;
using SmartHouse.Presentation.Views;

namespace SmartHouse.Presentation.Presenters
{
    public interface ISmartDevicePresenter
    {
    }

    public class SmartDevicePresenter : ISmartDevicePresenter
    {
        private readonly ISmartDeviceView _view;
        private readonly IDeviceModel _deviceModel;

        public SmartDevicePresenter(ISmartDeviceView smartDeviceView, IDeviceModel deviceModel)
        {
            _view = smartDeviceView;
            _deviceModel = deviceModel;

            AddCommandButtons(deviceModel);
        }

        private void AddCommandButtons(IDeviceModel deviceModel)
        {
            var commands = deviceModel.GetCommandsList();
            foreach (var command in commands)
            {
                var view = _view.AddButton(command.Name);
                view.OnExecuteCommand += () => ExecuteCommand(command.Id);
            }
        }

        private void ExecuteCommand(string commandId)
        {
            var status = _deviceModel.ExecuteCommand(commandId);
            _view.AddTextStatus(status);
        }
    }
}
