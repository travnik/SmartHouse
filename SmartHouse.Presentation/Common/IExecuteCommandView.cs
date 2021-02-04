using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse.Presentation.Common
{
    public interface IExecuteCommandView
    {
        string Name { get; set; }
        event Action OnExecuteCommand;
    }
}
