using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace Domain
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        MainVM mainVM = new MainVM();

        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);
            new MainWindow() { DataContext = mainVM }.Show();
        }
    }
}
