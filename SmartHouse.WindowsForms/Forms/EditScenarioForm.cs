using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using SmartHouse.DomainModel.SmartDevices.Common;
using SmartHouse.Presentation.Views;
using SmartHouse.Presentation.Views.ViewModels;

namespace SmartHouse.WindowsForms.Forms
{
    public partial class EditScenarioForm : Form, IEditScenarioView
    {
        public string ScriptName
        {
            get => textBoxScriptName.Text;
            set => textBoxScriptName.Text = value;
        }
        public IEnumerable<DeviceViewModel> SourceDevicesList { set => comboBoxDevices.DataSource = value; }
        public IEnumerable<DescriptCommand> SourceCommandsList { set => listBoxCommands.DataSource = value; }
        public BindingList<DescriptCommand> SourceScriptCommands { set => listBoxScript.DataSource = value; }

        public event Action<DeviceViewModel> DeviceSelected;
        public event Action<DescriptCommand> AddCommand;
        public event Action<DescriptCommand> RemoveCommand;
        public event Action ExecuteScript;
        public event Action SaveScript;

        public EditScenarioForm()
        {
            InitializeComponent();

            comboBoxDevices.SelectedValueChanged += ComboBoxDevicesOnSelectedValueChanged;
            buttonAddCommand.Click += ButtonAddCommandOnClick;
            buttonDeleteCommand.Click += ButtonDeleteCommandOnClick;
            buttonRunScript.Click += (sender, args) => ExecuteScript?.Invoke();
            buttonSaveScript.Click += (sender, args) => SaveScript?.Invoke();

            listBoxCommands.DisplayMember = nameof(DescriptCommand.CommandName);
            comboBoxDevices.DisplayMember = nameof(DeviceViewModel.Name);
        }

        private void ButtonDeleteCommandOnClick(object sender, EventArgs e)
        {
            var command = listBoxScript.SelectedItem as DescriptCommand;
            if (command != null)
            {
                RemoveCommand?.Invoke(command);
            }
        }

        private void ButtonAddCommandOnClick(object sender, EventArgs e)
        {
            var command = listBoxCommands.SelectedItem as DescriptCommand;
            if (command != null)
            {
                AddCommand?.Invoke(command);
            }
        }

        private void ComboBoxDevicesOnSelectedValueChanged(object sender, EventArgs e)
        {
            var comboBox = sender as ComboBox;
            var value = comboBox.SelectedItem as DeviceViewModel;
            var handler = DeviceSelected;
            handler?.Invoke(value);
        }

        public new void Show()
        {
            ShowDialog();
        }

        public void AddLog(string text)
        {
            textBoxLog.AppendText($"{text}{Environment.NewLine}");
        }
    }
}
