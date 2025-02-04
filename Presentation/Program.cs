using Microsoft.Extensions.DependencyInjection;
using System;
using System.Windows.Forms;

namespace Presentation
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            // Thiết lập DI container
            var serviceProvider = DependencyInjection.ConfigureServices();
            // Lấy MainForm từ DI container
            var formLogin = serviceProvider.GetRequiredService<Form1>();
            Application.Run(formLogin);
        }
    }
}
