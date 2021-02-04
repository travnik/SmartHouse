using System;
using System.Collections.Generic;
using SmartHouse.DomainModel.SmartDevices.Common;

namespace SmartHouse.DomainModel.SmartDevices
{
    public class CameraDeviceModel : DeviceModelBase
    {
        public override string Name => "Камера";
        protected override Dictionary<string, string> DescriptionCommands => _descriptionCommands;
        protected override Dictionary<string, Func<string>> ExecuteCommands => _executeCommands;

        private const string CommandOnId = "On";
        private const string CommandOffId = "Off";

        private static readonly Dictionary<string, string> _descriptionCommands = new Dictionary<string, string>()
        {
            {CommandOnId, "Включить обнаружение" },
            {CommandOffId, "Выключить обнаружение" }
        };

        private static readonly Dictionary<string, Func<string>> _executeCommands = new Dictionary<string, Func<string>>()
        {
            {CommandOnId, CommandOn},
            {CommandOffId, CommandOff}
        };

        private static string CommandOff()
        {
            return "Обнаружение выключено";
        }

        private static string CommandOn()
        {
            return "Обнаружение включено";
        }

    }
}
