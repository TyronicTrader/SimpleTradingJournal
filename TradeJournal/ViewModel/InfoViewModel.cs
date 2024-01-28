using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace TradeJournal.ViewModel
{
    internal partial class InfoViewModel : ViewModelBase
    {
        [ObservableProperty]
        private string appName = "Simple Trade Journal";

        [ObservableProperty]
        private string devName = "Developer";

        [ObservableProperty]
        private string devCrypto = "placeholder12309487oiqjfoklajsdfasdfkjhjkhuwe";

        [ObservableProperty]
        private string devPatreon = "https://www.patreon.com";

        [ObservableProperty]
        public string devPaypal = "https://www.paypal.com";

        [RelayCommand]
        public void OpenThePatreonHyperlink()
        {
            try
            {
                Process.Start(new ProcessStartInfo(DevPatreon) { UseShellExecute = true });
            }
            catch
            {
                MessageBox.Show("Link didn't work or can't open your default browser.");
            }

        }

        [RelayCommand]
        public void OpenThePayPalHyperlink()
        {
            try
            {
                Process.Start(new ProcessStartInfo(DevPaypal) { UseShellExecute = true });
            }
            catch
            {
                MessageBox.Show("Link didn't work or can't open your default browser.");
            }
        }

        [RelayCommand]
        public void CopyCryptoToClipboard()
        {
            Clipboard.SetText(DevCrypto);
            MessageBox.Show("Crypto Address copied to your clipboard");
        }
    }
}
