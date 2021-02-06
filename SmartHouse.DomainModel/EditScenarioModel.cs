using System;
using System.Collections.Generic;
using SmartHouse.DomainModel.SmartDevices;
using SmartHouse.DomainModel.SmartDevices.Common;

namespace SmartHouse.DomainModel
{
    public interface IEditScenarioModel
    {
        IEnumerable<IDeviceModel> GetDevices();
        IDeviceModel GetDevice(Guid deviceId);
    }

    public class EditScenarioModel : IEditScenarioModel
    {
        private readonly ISmartDevicesProvider _smartDevicesProvider;

        public EditScenarioModel(ISmartDevicesProvider smartDevicesProvider)
        {
            _smartDevicesProvider = smartDevicesProvider;
        }

        public IEnumerable<IDeviceModel> GetDevices()
        {
            return _smartDevicesProvider.GetDevices();
        }

        public IDeviceModel GetDevice(Guid deviceId)
        {
            return _smartDevicesProvider.GetDevice(deviceId);
        }
    }
}
