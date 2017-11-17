using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Threading;
using System.Windows;

namespace BBS.WPF
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private Mutex singleInstanceMutex;

        [DllImport("user32.dll")]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool SetForegroundWindow(IntPtr hWnd);

        protected override void OnExit(ExitEventArgs e)
        {
            if (singleInstanceMutex != null)
                singleInstanceMutex.ReleaseMutex();
            base.OnExit(e);
        }

        protected override void OnStartup(StartupEventArgs se)
        {
            bool firstInstance;

            singleInstanceMutex = new Mutex(true, "BBSMutex", out firstInstance);

            if (firstInstance)
            {
                Current.DispatcherUnhandledException += (s, e) => MessageBoxCreator.RaiseError(e.Exception.Message, e.Exception);
                MessageBoxCreator.OnRaiseWarning = (txt, title) => MessageBox.Show(txt, title, MessageBoxButton.OK, MessageBoxImage.Warning);
                MessageBoxCreator.OnRaiseError = ErrorWindow.Show;
                MessageBoxCreator.OnRaiseYesNo = (txt) => (MessageBox.Show(txt, "", MessageBoxButton.YesNo, MessageBoxImage.Stop) == MessageBoxResult.Yes);

                base.OnStartup(se);
            }
            else
            {
                singleInstanceMutex = null;
                // set focus to existing instance
                var current = Process.GetCurrentProcess();
                foreach (var process in Process.GetProcessesByName(current.ProcessName))
                {
                    if (process.Id == current.Id)
                        continue;
                    SetForegroundWindow(process.MainWindowHandle);
                    break;
                }
                Current.Shutdown(); //exit this instance
            }
        }
    }
}
