using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using Temperature_Converter.CommonUserControls;
using Temperature_Converter.ViewModels;
using Unity;

namespace Temperature_Converter
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            IUnityContainer container = new UnityContainer();
            var temperatureViewmodel = container.Resolve<TemperatureViewModel>();
            var mainWindow = container.Resolve<MainWindow>();
            var contentPlaceHolder = container.Resolve<ContentPlaceHolder>();
            contentPlaceHolder.DataContext = temperatureViewmodel;
            mainWindow.Content = contentPlaceHolder;
            mainWindow.WindowStartupLocation = WindowStartupLocation.CenterScreen;
            mainWindow.Show();

        }
    }
}
