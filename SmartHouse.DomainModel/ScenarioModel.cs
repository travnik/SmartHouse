using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SmartHouse.DomainModel.SmartDevices;
using SmartHouse.DomainModel.SmartDevices.Common;

namespace SmartHouse.DomainModel
{
    public interface IScenarioModel
    {
        IEnumerable<IDeviceModel> GetDevices();
        IDeviceModel GetDevice(Guid deviceId);
    }

    public class ScenarioModel : IScenarioModel
    {
        private readonly ISmartDevicesProvider _smartDevicesProvider;

        public ScenarioModel(ISmartDevicesProvider smartDevicesProvider)
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
