using System;
using System.Collections.Generic;
using SmartHouse.DomainModel.SmartDevices.Common;

namespace SmartHouse.DomainModel.SmartDevices
{
    public class BoilerDeviceModel : DeviceModelBase
    {
        public override string Name => "Котел";
        protected override Dictionary<string, string> DescriptionCommands => _descriptionCommands;
        protected override Dictionary<string, Func<string>> ExecuteCommands => _executeCommands;

        private const string CommandOnId = "On";
        private const string CommandOffId = "Off";
        private const string CommandIncTempId = "IncTemp";
        private const string CommandDecTempId = "DeccTemp";

        private int _temp = 0;

        private static readonly Dictionary<string, string> _descriptionCommands = new Dictionary<string, string>()
        {
            {CommandOnId, "Включить" },
            {CommandOffId, "Выключить" },
            {CommandIncTempId, "+1град температура" },
            {CommandDecTempId, "-1град температура" }
        };

        private readonly Dictionary<string, Func<string>> _executeCommands = new Dictionary<string, Func<string>>();

        public BoilerDeviceModel()
        {
            _executeCommands.Add(CommandOnId, CommandOn);
            _executeCommands.Add(CommandOffId, CommandOff);
            _executeCommands.Add(CommandIncTempId, CommandIncTemp);
            _executeCommands.Add(CommandDecTempId, CommandDecTemp);
        }

        private string CommandOff()
        {
            return "Котел выключен";
        }

        private string CommandOn()
        {
            return "Котел включен";
        }

        private string CommandIncTemp()
        {
            _temp++;
            return GetTemperature();
        }

        private string CommandDecTemp()
        {
            _temp--;
            return GetTemperature();
        }

        private string GetTemperature()
        {
            return $"Установленная температура: {_temp} градусов";
        }
    }
}
