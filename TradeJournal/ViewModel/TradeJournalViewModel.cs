using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeJournal.ViewModel
{
    internal partial class TradeJournalViewModel : ViewModelBase
    {
        [ObservableProperty]
        string theTextBox = "The Silly String";

        [RelayCommand]
        internal void ButtonOnClick()
        {
            if (TheTextBox == "The Silly String")
            {
                TheTextBox = "The Silly String has Changed!!!";
            }
            else
            {
                TheTextBox = "The Silly String";
            }
        }
    }
}
