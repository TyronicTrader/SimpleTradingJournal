using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using TradeJournal.ViewModel;
using System.Diagnostics;

namespace TradeJournal.View
{
    /// <summary>
    /// Interaction logic for InfoView.xaml
    /// </summary>
    public partial class InfoView : UserControl
    {
        public InfoView()
        {
            InitializeComponent();
            DataContext = new InfoViewModel();
        }

        /// <summary>
        /// this will be called to open up URLs into the default browser but deprecated after finding way to do in viewModel
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        //public void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        //{
        //    Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri) { UseShellExecute = true });
        //    e.Handled = true;
        //}
    }
}
