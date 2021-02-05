using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SmartHouse.DomainModel.SmartDevices.Common;
using SmartHouse.Presentation.Views;
using SmartHouse.Presentation.Views.ViewModels;

namespace SmartHouse.WindowsForms.Forms
{
    public partial class ScenarioForm : Form, IScenarioView
    {
        public event Action<DeviceViewModel> DeviceSelected;
        public event Action<DescriptCommand> AddCommand;

        public ScenarioForm()
        {
            InitializeComponent();
            comboBoxDevices.SelectedValueChanged += ComboBoxDevicesOnSelectedValueChanged;
            buttonAddCommand.Click += ButtonAddCommandOnClick; 
        }

        private void ButtonAddCommandOnClick(object sender, EventArgs e)
        {
            var command = listBoxCommands.SelectedItem as DescriptCommand;
            AddCommand?.Invoke(command);
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
            Application.Run(this);
        }
    }
}
