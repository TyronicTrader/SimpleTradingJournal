using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.Windows.Themes;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.WindowManagement;

namespace TradeJournal.ViewModel
{
    internal partial class TradeJournalViewModel : ViewModelBase
    {
        public TradeJournalViewModel()
        {
            ExecuteShowDashboardView();
        }

        [ObservableProperty]
        private ViewModelBase? currentChildView;

        [ObservableProperty]
        private string? caption;

        #region Commands for setting the active child window and caption
        [RelayCommand]
        internal void ExecuteShowDashboardView()
        {
            CurrentChildView = new DashboardViewModel();
            Caption = "Dashboard";
        }

        [RelayCommand]
        internal void ExecuteShowJournalView()
        {
            CurrentChildView = new JournalViewModel();
            Caption = "Journal";
        }

        [RelayCommand]
        internal void ExecuteShowMetricsView()
        {
            CurrentChildView = new MetricsViewModel();
            Caption = "Metrics";
        }

        [RelayCommand]
        internal void ExecuteShowEventsView() 
        {
            CurrentChildView = new EventsViewModel();
            Caption = "Events";
        }

        [RelayCommand]
        internal void ExecuteShowRSSView()
        {
            CurrentChildView = new RSSViewModel();
            Caption = "RSS";
        }

        [RelayCommand]
        internal void ExecuteShowSearchView()
        {
            CurrentChildView = new SearchViewModel();
            Caption = "Search";
        }

        [RelayCommand]
        internal void ExecuteShowSettingsView()
        {
            CurrentChildView = new SettingsViewModel();
            Caption = "Settings"; 
        }

        [RelayCommand]
        internal void ExecuteShowInfoView()
        {
            CurrentChildView = new InfoViewModel();
            Caption = "Info";
        }
        #endregion












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
