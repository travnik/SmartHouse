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

        public void BindCommandsList(IEnumerable<DescriptCommand> commands)
        {
            listBoxCommands.DataSource = commands;
            listBoxCommands.DisplayMember = nameof(DescriptCommand.CommandName);
            listBoxCommands.ValueMember = nameof(DescriptCommand.CommandId);
        }

        public void BindDevicesList(IEnumerable<DeviceViewModel> devices)
        {
            comboBoxDevices.DataSource = devices;
            comboBoxDevices.DisplayMember = nameof(DeviceViewModel.Name);
            comboBoxDevices.ValueMember = nameof(DeviceViewModel.Id);
        }

        public void BindScript(BindingList<DescriptCommand> scriptCommands)
        {
            listBoxScript.DataSource = scriptCommands;
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
