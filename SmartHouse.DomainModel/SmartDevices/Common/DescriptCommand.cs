using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse.DomainModel.SmartDevices.Common
{
    public class DescriptCommand
    {
        public Guid DeviceId { get; set; }
        public string DeviceName { get; set; }
        public string CommandId { get; set; }
        public string CommandName { get; set; }

        public override string ToString()
        {
            return $"{DeviceName}: {CommandName}";
        }
    }
}
