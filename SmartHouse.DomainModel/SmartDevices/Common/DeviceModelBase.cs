using System;
using System.Collections.Generic;
using System.Linq;

namespace SmartHouse.DomainModel.SmartDevices.Common
{
    public interface IDeviceModel
    {
        Guid Id { get; }
        string Name { get; }
        IEnumerable<(string Id, string Name)> GetCommandsList();
        string ExecuteCommand(string commandId);
    }

    public abstract class DeviceModelBase : IDeviceModel
    {
        public Guid Id { get; } = Guid.NewGuid();
        public abstract string Name { get; }

        protected abstract Dictionary<string, string> DescriptionCommands { get; }
        protected abstract Dictionary<string, Func<string>> ExecuteCommands { get; }


        public IEnumerable<(string Id, string Name)> GetCommandsList()
        {
            return DescriptionCommands
                .Select(o => (o.Key, o.Value))
                .ToList();
        }

        public string ExecuteCommand(string commandId)
        {
            return ExecuteCommands[commandId].Invoke();
        }
    }
}