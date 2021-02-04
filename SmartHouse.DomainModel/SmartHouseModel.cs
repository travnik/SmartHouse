using System.Collections.Generic;
using SmartHouse.DomainModel.SmartDevices;
using SmartHouse.DomainModel.SmartDevices.Common;

namespace SmartHouse.DomainModel
{
    public interface ISmartHouseModel
    {
        IEnumerable<IDeviceModel> GetDevices();
    }

    public class SmartHouseModel : ISmartHouseModel
    {
        private readonly ISmartDevicesProvider _smartDevicesProvider;

        public SmartHouseModel(ISmartDevicesProvider smartDevicesProvider)
        {
            _smartDevicesProvider = smartDevicesProvider;
        }

        public IEnumerable<IDeviceModel> GetDevices()
        {
            return _smartDevicesProvider.GetDevices();
        }
    }
}
