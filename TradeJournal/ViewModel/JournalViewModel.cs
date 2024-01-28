using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradeJournal.ViewModel
{
    internal partial class JournalViewModel : ViewModelBase
    {
        [ObservableProperty]
        string theTextBox = "the String";


    }
}
