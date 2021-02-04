using System;
using System.Collections.Generic;
using System.Text;
using SmartHouse.DomainModel.SmartDevices.Common;

namespace SmartHouse.DomainModel.SmartDevices
{
    public class TemperatureSensorDeviceModel : DeviceModelBase
    {
        public override string Name => "Датчик температуры";
        protected override Dictionary<string, string> DescriptionCommands => _descriptionCommands;
        protected override Dictionary<string, Func<string>> ExecuteCommands => _executeCommands;

        private const string CommandOnId = "On";
        private const string CommandOffId = "Off";

        private static readonly Dictionary<string, string> _descriptionCommands = new Dictionary<string, string>()
        {
            {CommandOnId, "Включить изменение температуры" },
            {CommandOffId, "Выключить изменение температуры" }
        };

        private static readonly Dictionary<string, Func<string>> _executeCommands = new Dictionary<string, Func<string>>()
        {
            {CommandOnId, CommandOn},
            {CommandOffId, CommandOff}
        };

        private static string CommandOff()
        {
            return "Выключение изменение температуры";
        }

        private static string CommandOn()
        {
            return "Включение изменение температуры";
        }

    }
}
