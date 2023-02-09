using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace DesignboticAddMaterialDesingBugLauncher
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        public App()
        {

        }
        protected override async void OnStartup(StartupEventArgs e)
        {
            var startupForm = new MainWindow();
            startupForm.Content = new BasicPageClean();  
            startupForm.Show();
            base.OnStartup(e);
        }
    }
}
