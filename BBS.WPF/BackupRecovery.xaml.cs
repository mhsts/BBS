using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.IO;

namespace BBS.WPF
{
    /// <summary>
    /// Interaction logic for BackupRecovery.xaml
    /// </summary>
    public partial class BackupRecovery : Window
    {
        public BackupRecovery()
        {
            InitializeComponent();

            var bestFile = GetBestBackupFile();

            if (bestFile != null)
            {
                mostLikelyBackupLabel.Text = string.Format("Beste backup: {0}\nGrootte: {1}kb", bestFile.Name, bestFile.Length / 1024);

                backupButton.Click += (s, e) =>
                {
                    string corruptFileBackup = string.Format("corrupt_{0}.crypt", DateTime.Now.ToString("MMddyyyyHHmmss"));
                    File.Copy("session.crypt", corruptFileBackup, true);
                    File.Copy(bestFile.FullName, "session.crypt", true);
                    Session.Load();
                    Exit(true);
                };
            }
            else
            {
                backupButton.IsEnabled = false;
                backupButton.Content = "{geen backup}";
            }
        }

        private FileInfo GetBestBackupFile()
        {
            int minimalFileSize = 20 * 1024; //20kb
            if (!Directory.Exists(Session.BackupPath))
                return null;
            var backupFiles = Directory.GetFiles(Session.BackupPath,"*.crypt").Select(bf => new FileInfo(bf));
            var backupsInOrder = backupFiles.Where(bf => bf.Length > minimalFileSize).OrderByDescending(bf => bf.LastWriteTime).ToList();
            return backupsInOrder.FirstOrDefault();
        }

        private void sluitenButton_Click(object sender, RoutedEventArgs e)
        {
            Exit(false);
        }

        private void doorgaanButton_Click(object sender, RoutedEventArgs e)
        {
            Exit(true);
        }

        private bool buttonClose = false;

        private void Exit(bool success)
        {
            if (success)
            {
                buttonClose = true;
                DialogResult = true;
            }
            else
            {
                Session.SkipSaveOnExit = true;
                Application.Current.Shutdown();
            }
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!buttonClose)
            {
                Exit(false);
            }
        }
    }
}
