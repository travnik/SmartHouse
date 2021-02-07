using System;
using System.Collections.Generic;
using SmartHouse.DomainModel.Scripts;
using SmartHouse.DomainModel.SmartDevices;
using SmartHouse.DomainModel.SmartDevices.Common;

namespace SmartHouse.DomainModel
{
    public interface IEditScenarioModel
    {
        IEnumerable<IDeviceModel> GetDevices();
        IDeviceModel GetDevice(Guid deviceId);
        ScriptModel Save(ScriptModel scriptModel, IEnumerable<DescriptCommand> commands);
        string Execute(DescriptCommand command);
    }

    public class EditScenarioModel : IEditScenarioModel
    {
        private readonly ISmartDevicesProvider _smartDevicesProvider;
        private readonly IScriptRepository _scriptRepository;

        public EditScenarioModel(ISmartDevicesProvider smartDevicesProvider, 
            IScriptRepository scriptRepository)
        {
            _smartDevicesProvider = smartDevicesProvider;
            _scriptRepository = scriptRepository;
        }

        public IEnumerable<IDeviceModel> GetDevices()
        {
            return _smartDevicesProvider.GetDevices();
        }

        public IDeviceModel GetDevice(Guid deviceId)
        {
            return _smartDevicesProvider.GetDevice(deviceId);
        }

        public ScriptModel Save(ScriptModel scriptModel, IEnumerable<DescriptCommand> commands)
        {
            scriptModel.DescriptCommands.Clear();
            scriptModel.DescriptCommands.AddRange(commands);
            return _scriptRepository.AddOrUpdate(scriptModel);
        }

        public string Execute(DescriptCommand command)
        {
            var device = _smartDevicesProvider.GetDevice(command.DeviceId);
            return device.ExecuteCommand(command.CommandId);
        }
    }
}
