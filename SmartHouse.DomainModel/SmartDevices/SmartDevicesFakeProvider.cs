using System.Collections.Generic;
using SmartHouse.DomainModel.SmartDevices.Common;

namespace SmartHouse.DomainModel.SmartDevices
{
    public interface ISmartDevicesProvider
    {
        IEnumerable<IDeviceModel> GetDevices();
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
    }
}
