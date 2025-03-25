using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace drugstore
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static byte[] Received { get; set; } //принимает запросы
        private async void Application_Startup(object sender, StartupEventArgs e)
        {
            Received = new byte[2048];
            await Client.GetInstance().Connect();
        }
    }
}
