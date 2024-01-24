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
using System.Windows.Shapes;
using TradeJournal.ViewModel;
using System.Configuration;
using Microsoft.Win32.SafeHandles;
using System.Collections.Specialized;

namespace TradeJournal.View
{
    /// <summary>
    /// Interaction logic for TradeJournalView.xaml
    /// </summary>
    public partial class TradeJournalView : Window
    {

        //private Configuration AppConfig = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoamingAndLocal);

        

        public TradeJournalView()
        {
            
            InitializeComponent();
            DataContext = new TradeJournalViewModel(); 
            System.Diagnostics.Debug.WriteLine("HELLO MO JO!!!!!!!!");




            //Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.PerUserRoaming);
            //UserSettings settings;
            //if ((settings = (UserSettings)configuration.Sections[GENERAL_USER_SETTINGS]) == null)
            //{
            //    settings = new UserSettings();
            //    settings.SectionInformation.AllowExeDefinition =
            //               ConfigurationAllowExeDefinition.MachineToLocalUser;
            //    configuration.Sections.Add(GENERAL_USER_SETTINGS, settings);
            //    configuration.Save();
            //}







            //string? test = ConfigurationManager.AppSettings["Setting1"];
            //System.Diagnostics.Debug.WriteLine(ConfigurationManager.AppSettings["Setting2"]);
            //System.Diagnostics.Debug.WriteLine(test);


            ////string? test2 = Properties.Settings.Default.Setting3;
            ////System.Diagnostics.Debug.WriteLine(Properties.Settings.Default.Setting3);
            ////System.Diagnostics.Debug.WriteLine(ConfigurationManager.UserSettings["Setting3"]);

            ////System.Diagnostics.Debug.WriteLine(test2);


            ////test = "this is the other string VALUE";
            ////Properties.Settings.Default.Setting3 = test;
            //////Properties.Settings.Default.Setting4 = test;
            ////Properties.Settings.Default.Save();

            //var applicationSettings = ConfigurationManager.GetSection("TradingJournalAppSettings") as NameValueCollection;
            //if (applicationSettings.Count == 0)
            //{
            //    Console.WriteLine("Application Settings are not defined");
            //}
            //else
            //{
            //    foreach (var key in applicationSettings.AllKeys)
            //    {
            //        System.Diagnostics.Debug.WriteLine(key + " = " + applicationSettings[key]);
            //    }
            //}
            //System.Diagnostics.Debug.WriteLine(applicationSettings.GetKey(2));
            //System.Diagnostics.Debug.WriteLine(applicationSettings.GetValues(1));
            //System.Diagnostics.Debug.WriteLine(applicationSettings.Get("SecretKey"));
            
            ////applicationSettings.Set("Testing", "TestingValue");
            ////System.Diagnostics.Debug.WriteLine(applicationSettings.Get("Testing"));


        }

        private void Image_MouseEnter(object sender, MouseEventArgs e)
        {

        }
    }
}
