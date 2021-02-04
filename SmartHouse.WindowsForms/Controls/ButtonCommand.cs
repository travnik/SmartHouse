using System;
using System.Windows.Forms;
using SmartHouse.Presentation.Common;
using IContainer = System.ComponentModel.IContainer;

namespace SmartHouse.WindowsForms.Controls
{
    public partial class ButtonCommand : Button, IExecuteCommandView
    {
        public event Action OnExecuteCommand;

        public ButtonCommand()
        {
            InitializeComponent();

            Click += (sender, args) =>
            {
                var handler = OnExecuteCommand;
                if (handler != null)
                {
                    Invoke(OnExecuteCommand);
                }
            };
        }

        public ButtonCommand(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
