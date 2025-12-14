using System;
using System.Windows.Forms;

namespace NEXT_Tuning_App
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            // Ensure per-monitor DPI awareness is enabled before initializing application configuration
            Application.SetHighDpiMode(HighDpiMode.PerMonitorV2);
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}