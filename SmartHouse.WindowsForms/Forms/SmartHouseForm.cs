using System;
using System.Windows.Forms;
using SmartHouse.Presentation.Views;
using SmartHouse.WindowsForms.Controls;

namespace SmartHouse.WindowsForms.Forms
{
    public partial class SmartHouseForm : Form, ISmartHouseView
    {
        public SmartHouseForm()
        {
            InitializeComponent();
        }

        public new void Show()
        {
            Application.Run(this);
        }

        public ISmartDeviceView AddSmartDevice()
        {
            var tabPage = new SmartDeviceControl();
            tabControlDevices.TabPages.Add(tabPage);
            return tabPage;
        }
    }
}
