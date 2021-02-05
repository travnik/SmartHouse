using System;
using System.Collections.Generic;
using System.Linq;
using SmartHouse.DomainModel.SmartDevices.Common;

namespace SmartHouse.DomainModel.SmartDevices
{
    public interface ISmartDevicesProvider
    {
        IEnumerable<IDeviceModel> GetDevices();
        IDeviceModel GetDevice(Guid deviceId);
    }

    public class SmartDevicesFakeProvider : ISmartDevicesProvider
    {
        private static readonly List<IDeviceModel> _deviceModels = new List<IDeviceModel>();

        public IEnumerable<IDeviceModel> GetDevices()
        {
            return _deviceModels;
        }

        public static void AddDevice(IDeviceModel device)
        {
            _deviceModels.Add(device);
        }

        public IDeviceModel GetDevice(Guid deviceId)
        {
            return GetDevices().First(o => o.Id == deviceId);
        }
    }
}
