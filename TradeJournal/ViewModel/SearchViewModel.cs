using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeJournal.ViewModel
{
    internal partial class SearchViewModel : ViewModelBase
    {
        [ObservableProperty]
        string theTextBox = "this is the string";
    }
}
