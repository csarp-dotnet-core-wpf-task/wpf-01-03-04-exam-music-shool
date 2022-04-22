using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

using MusicShoolWPFApp.View;
using MusicShoolWPFApp.ViewModels;

namespace MusicShoolWPFApp
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        protected override void OnStartup(StartupEventArgs e)
        {
            MainWindow window = new MainWindow();
            MusicSchoolMarkViewModel musicSchoolMarkViewModel = new MusicSchoolMarkViewModel();

            window.DataContext = musicSchoolMarkViewModel;
            window.Show();
            base.OnStartup(e);
        }
    }
}
