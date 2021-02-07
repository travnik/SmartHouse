using System;
using System.Collections.Generic;
using SmartHouse.DomainModel.SmartDevices.Common;

namespace SmartHouse.DomainModel.Scripts
{
    public class ScriptModel
    {
        public readonly Guid Id = Guid.NewGuid();

        public string Name { get; set; }

        public readonly List<DescriptCommand> DescriptCommands = new List<DescriptCommand>();
    }
}
