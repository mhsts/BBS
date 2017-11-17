using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Windows;

namespace BBS.WPF
{
    public class CardReader
    {
        private DispatcherTimer timer = new DispatcherTimer();
        private StringBuilder barCodeSB = new StringBuilder();

        public CardReader(Window window)
        {
            timer.IsEnabled = false;
            timer.Interval = new TimeSpan(0, 0, 0, 0, 350);
            timer.Tick += new EventHandler(timer_Tick);

            window.PreviewTextInput += new System.Windows.Input.TextCompositionEventHandler(window_PreviewTextInput);
        }

        void timer_Tick(object sender, EventArgs e)
        {
            timer.IsEnabled = false;

            if (barCodeSB.Length >= 8)
            {
                string barCode = barCodeSB.ToString();
                if (barCode.EndsWith("\r"))
                {
                    barCode = barCode.Substring(0, barCode.Length - 1);
                }
                if (this.Scanned != null)
                    this.Scanned(new BarCode(barCode));
            }

            barCodeSB = new StringBuilder(); //reset barcode
        }

        public Action<BarCode> Scanned;

        void window_PreviewTextInput(object sender, System.Windows.Input.TextCompositionEventArgs e)
        {
            if (!timer.IsEnabled)
                timer.IsEnabled = true;
            
            barCodeSB.Append(e.Text);
        }       
    }
}
