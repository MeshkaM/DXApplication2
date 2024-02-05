using DevExpress.Xpf.Core;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Windows;


namespace DXApplication2
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        static App()
        {
            CompatibilitySettings.UseLightweightThemes = true;
        }
        protected override void OnStartup(StartupEventArgs e)
        {
            Xceed.Wpf.DataGrid.Licenser.LicenseKey = "DGP71-C8C50-XN68W-JFTA";
            Xceed.Wpf.Toolkit.Licenser.LicenseKey = "WTK44-EZ2A0-GX6XW-P7RA";
            base.OnStartup(e);
        }
    }
}
