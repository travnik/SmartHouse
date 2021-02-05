using System;
using System.Windows.Forms;
using SmartHouse.DomainModel;
using SmartHouse.DomainModel.SmartDevices;
using SmartHouse.Presentation.Common;
using SmartHouse.Presentation.Presenters;
using SmartHouse.Presentation.Views;

namespace SmartHouse.WindowsForms
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            AddDevices();

            var controller = ConfigureServices();
            controller.Run<ScenarioPresenter>();
            //controller.Run<SmartHousePresenter>();
        }

        private static IApplicationController ConfigureServices()
        {
            return new ApplicationController(new LightInjectAdapder())
                .RegisterService<ISmartDevicesProvider, SmartDevicesFakeProvider>()
                .RegisterView<ISmartHouseView, Forms.SmartHouseForm>()
                .RegisterService<ISmartHouseModel, SmartHouseModel>()
                .RegisterView<IScenarioView, Forms.ScenarioForm>()
                .RegisterService<IScenarioModel, ScenarioModel>()
                .RegisterInstance(new ApplicationContext());
        }

        private static void AddDevices()
        {
            SmartDevicesFakeProvider.AddDevice(new CameraDeviceModel());
            SmartDevicesFakeProvider.AddDevice(new BoilerDeviceModel());
            SmartDevicesFakeProvider.AddDevice(new TemperatureSensorDeviceModel());
        }
    }
}
