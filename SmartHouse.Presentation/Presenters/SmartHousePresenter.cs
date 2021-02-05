using System.Collections.Generic;
using SmartHouse.DomainModel;
using SmartHouse.Presentation.Common;
using SmartHouse.Presentation.Views;

namespace SmartHouse.Presentation.Presenters
{
    public class SmartHousePresenter : BasePresener<ISmartHouseView>
    {
        private readonly ISmartHouseModel _smartHouseModel;

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
                var smartDeviceView = View.AddSmartDevice();
                var _ = new SmartDevicePresenter(smartDeviceView, deviceModel);
            }
        }
    }
}
