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
        BindingList<DescriptCommand> DescriptCommands { get; }
        void AddCommand(DescriptCommand descriptCommand);
    }

    public class ScenarioModel : IScenarioModel
    {
        private readonly ISmartDevicesProvider _smartDevicesProvider;

        public BindingList<DescriptCommand> DescriptCommands { get; } = new BindingList<DescriptCommand>();

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

        public void AddCommand(DescriptCommand descriptCommand)
        {
            DescriptCommands.Add(descriptCommand);
        }
    }
}
