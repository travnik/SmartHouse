using System;
using System.Collections.Generic;
using System.Text;
using SmartHouse.DomainModel.SmartDevices.Common;

namespace SmartHouse.DomainModel.Scripts
{
    public class ScriptModel
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public List<DescriptCommand> DescriptCommands { get; set; }
    }
}
