using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using SmartHouse.Presentation.Common;
using SmartHouse.Presentation.Views.ViewModels;

namespace SmartHouse.Presentation.Views
{
    public interface IScenariosView : IView
    {
        event Action NewScript;

        event Action<ScriptViewModel> EditScript;

        event Action<ScriptViewModel> RemoveScript;

        IEnumerable<ScriptViewModel> SourceScripts { set; }
    }
}
