using SEM_log.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SEM_log
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MyCustomApplicationContext());
        }

        public class MyCustomApplicationContext : ApplicationContext
        {
            private NotifyIcon trayIcon;

            public MyCustomApplicationContext()
            {
                // Initialize Tray Icon
                trayIcon = new NotifyIcon()
                {
                    Icon = Resources.Fan,
                    ContextMenu = new ContextMenu(new MenuItem[] {
                    new MenuItem("Exit", Exit),
                    new MenuItem("Log viewer", LogView),
                    new MenuItem("Login", Login),
                    new MenuItem("About", About)
                    }),
                    Visible = true
                };

                var login = new FormLogin();
                login.Show();
            }

            void Exit(object sender, EventArgs e)
            {
                // Hide tray icon, otherwise it will remain shown until user mouses over it
                trayIcon.Visible = false;

                Application.Exit();
            }
            void LogView(object sender, EventArgs e)
            {
                var log = new FormLog();
                log.Show();
            }
            public void Login(object sender, EventArgs e)
            {
                var login = new FormLogin();
                login.Show();
            }

            void About(object sender, EventArgs e)
            {
                MessageBox.Show("Created by Fan. " +
                    "Released under GPL v3 license. ",
                    "SEM log", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
