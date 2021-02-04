using System.Collections.Generic;
using SmartHouse.DomainModel;
using SmartHouse.Presentation.Common;
using SmartHouse.Presentation.Views;

namespace SmartHouse.Presentation.Presenters
{
    public class SmartHousePresenter : BasePresener<ISmartHouseView>
    {
        private readonly ISmartHouseModel _smartHouseModel;

        private readonly List<ISmartDevicePresenter> _smartDevicePresenters = new List<ISmartDevicePresenter>();

        public SmartHousePresenter(IApplicationController controller, 
            ISmartHouseView view, 
            ISmartHouseModel smartHouseModel) 
            : base(controller, view)
        {
            _smartHouseModel = smartHouseModel;
            AddDevicesToView();
        }

        private void AddDevicesToView()
        {
            var devices = _smartHouseModel.GetDevices();
            foreach (var deviceModel in devices)
            {
                var smartDeviceView = View.AddSmartDevice(deviceModel.Name);
                var presenter = new SmartDevicePresenter(smartDeviceView, deviceModel);
                _smartDevicePresenters.Add(presenter);
            }
        }
    }
}
