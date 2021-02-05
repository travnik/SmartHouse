﻿using System;
using System.Windows.Forms;
using SmartHouse.Presentation.Common;
using SmartHouse.Presentation.Views;

namespace SmartHouse.WindowsForms.Controls
{
    public partial class SmartDeviceControl : TabPage, ISmartDeviceView
    {
        public SmartDeviceControl()
        {
            InitializeComponent();
        }

        public IExecuteCommandView AddButton()
        {
            var button = new ButtonCommand();
            flowLayoutPanelCommands.Controls.Add(button);

            return button;
        }

        public string DisplayName
        {
            get => Text;
            set => Text = value;
        }

        public void AddTextStatus(string text)
        {
            textBoxStatus.AppendText($"{text}{Environment.NewLine}");
        }
    }
}
