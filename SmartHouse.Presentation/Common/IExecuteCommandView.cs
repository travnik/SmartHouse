using System;
using System.Collections.Generic;
using System.Text;

namespace SmartHouse.Presentation.Common
{
    public interface IExecuteCommandView
    {
        string DisplayName { get; set; }
        event Action OnExecuteCommand;
    }
}
