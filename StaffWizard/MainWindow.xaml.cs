using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data.SqlClient;
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
using SystemAndersson.Anet.BI.LoginSQL;
using SystemAndersson.Anet.BI.Registry;
using SystemAndersson.Anet.BI.TimeSchedule;

namespace StaffWizard
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public SqlConnection AConn;
        List<DayScheduleDesc> DayScheduleList;
        public MainWindow()
        {
            InitializeComponent();
            Servers serv = new Servers();
            AConn=serv.CreateConnection("AnetCompany02");
            DayScheduleList = DayScheduleDescReg.GetDayScheduleDesc(AConn);
            DayScheduleGrid.ItemsSource = DayScheduleList;
            List<Staff> StaffList = StaffReg.GetStaff(AConn);
            StaffGrid.ItemsSource = StaffList;
            GWeek1.Visibility = Visibility.Visible;
            GWeek2.Visibility = Visibility.Collapsed;
            GWeek3.Visibility = Visibility.Collapsed;
            Gweek4.Visibility = Visibility.Collapsed;
            Gweek5.Visibility = Visibility.Collapsed;
            Gweek6.Visibility = Visibility.Collapsed;
            cbMonday1.ItemsSource = DayScheduleList;
            cbTuesday1.ItemsSource = DayScheduleList;
            cbWednesday1.ItemsSource = DayScheduleList;
            cbThursday1.ItemsSource = DayScheduleList;
            cbFriday1.ItemsSource = DayScheduleList;
            cbSaturday1.ItemsSource = DayScheduleList;
            cbSunday1.ItemsSource = DayScheduleList;
            GStartWeek.Visibility = Visibility.Collapsed;
        }

        

        private void DataGrid_Initialized(object sender, EventArgs e)
        {
           
           
        }

        private void DataGrid_Initialized_1(object sender, EventArgs e)
        {
           
        }

       

        private void RadioButton_Click_1(object sender, RoutedEventArgs e)
        {
            GWeek1.Visibility = Visibility.Visible;
            GWeek2.Visibility = Visibility.Collapsed;
            GWeek3.Visibility = Visibility.Collapsed;
            Gweek4.Visibility = Visibility.Collapsed;
            Gweek5.Visibility = Visibility.Collapsed;
            Gweek6.Visibility = Visibility.Collapsed;
            GStartWeek.Visibility = Visibility.Collapsed;
            cbMonday1.ItemsSource = DayScheduleList;
            cbTuesday1.ItemsSource = DayScheduleList;
            cbWednesday1.ItemsSource = DayScheduleList;
            cbThursday1.ItemsSource = DayScheduleList;
            cbFriday1.ItemsSource = DayScheduleList;
            cbSaturday1.ItemsSource = DayScheduleList;
            cbSunday1.ItemsSource = DayScheduleList;
        }

        private void RadioButton_Click_2(object sender, RoutedEventArgs e)
        {
            GWeek1.Visibility = Visibility.Visible;
            GWeek2.Visibility = Visibility.Visible;
            GWeek3.Visibility = Visibility.Collapsed;
            Gweek4.Visibility = Visibility.Collapsed;
            Gweek5.Visibility = Visibility.Collapsed;
            Gweek6.Visibility = Visibility.Collapsed;
            GStartWeek.Visibility = Visibility.Visible;
            string[] startweekarray = {"1","2"};

            cbstartweek.ItemsSource = startweekarray;
            cbMonday1.ItemsSource = DayScheduleList;
            cbTuesday1.ItemsSource = DayScheduleList;
            cbWednesday1.ItemsSource = DayScheduleList;
            cbThursday1.ItemsSource = DayScheduleList;
            cbFriday1.ItemsSource = DayScheduleList;
            cbSaturday1.ItemsSource = DayScheduleList;
            cbSunday1.ItemsSource = DayScheduleList;
            cbMonday2.ItemsSource = DayScheduleList;
            cbTuesday2.ItemsSource = DayScheduleList;
            cbWednesday2.ItemsSource = DayScheduleList;
            cbThursday2.ItemsSource = DayScheduleList;
            cbFriday2.ItemsSource = DayScheduleList;
            cbSaturday2.ItemsSource = DayScheduleList;
            cbSunday2.ItemsSource = DayScheduleList;
        }

        private void RadioButton_Click_3(object sender, RoutedEventArgs e)
        {
            GWeek1.Visibility = Visibility.Visible;
            GWeek2.Visibility = Visibility.Visible;
            GWeek3.Visibility = Visibility.Visible;
            Gweek4.Visibility = Visibility.Collapsed;
            Gweek5.Visibility = Visibility.Collapsed;
            Gweek6.Visibility = Visibility.Collapsed;
            GStartWeek.Visibility = Visibility.Visible;
            string[] startweekarray = { "1", "2","3" };

            cbstartweek.ItemsSource = startweekarray;
            cbMonday1.ItemsSource = DayScheduleList;
            cbTuesday1.ItemsSource = DayScheduleList;
            cbWednesday1.ItemsSource = DayScheduleList;
            cbThursday1.ItemsSource = DayScheduleList;
            cbFriday1.ItemsSource = DayScheduleList;
            cbSaturday1.ItemsSource = DayScheduleList;
            cbSunday1.ItemsSource = DayScheduleList;
            cbMonday2.ItemsSource = DayScheduleList;
            cbTuesday2.ItemsSource = DayScheduleList;
            cbWednesday2.ItemsSource = DayScheduleList;
            cbThursday2.ItemsSource = DayScheduleList;
            cbFriday2.ItemsSource = DayScheduleList;
            cbSaturday2.ItemsSource = DayScheduleList;
            cbSunday2.ItemsSource = DayScheduleList;
            cbMonday3.ItemsSource = DayScheduleList;
            cbTuesday3.ItemsSource = DayScheduleList;
            cbWednesday3.ItemsSource = DayScheduleList;
            cbThursday3.ItemsSource = DayScheduleList;
            cbFriday3.ItemsSource = DayScheduleList;
            cbSaturday3.ItemsSource = DayScheduleList;
            cbSunday3.ItemsSource = DayScheduleList;
        }

        private void RadioButton_Click_4(object sender, RoutedEventArgs e)
        {
            GWeek1.Visibility = Visibility.Visible;
            GWeek2.Visibility = Visibility.Visible;
            GWeek3.Visibility = Visibility.Visible;
            Gweek4.Visibility = Visibility.Visible;
            Gweek5.Visibility = Visibility.Collapsed;
            Gweek6.Visibility = Visibility.Collapsed;
            GStartWeek.Visibility = Visibility.Visible;
            string[] startweekarray = { "1", "2", "3", "4" };

            cbstartweek.ItemsSource = startweekarray;
            cbMonday1.ItemsSource = DayScheduleList;
            cbTuesday1.ItemsSource = DayScheduleList;
            cbWednesday1.ItemsSource = DayScheduleList;
            cbThursday1.ItemsSource = DayScheduleList;
            cbFriday1.ItemsSource = DayScheduleList;
            cbSaturday1.ItemsSource = DayScheduleList;
            cbSunday1.ItemsSource = DayScheduleList;
            cbMonday2.ItemsSource = DayScheduleList;
            cbTuesday2.ItemsSource = DayScheduleList;
            cbWednesday2.ItemsSource = DayScheduleList;
            cbThursday2.ItemsSource = DayScheduleList;
            cbFriday2.ItemsSource = DayScheduleList;
            cbSaturday2.ItemsSource = DayScheduleList;
            cbSunday2.ItemsSource = DayScheduleList;
            cbMonday3.ItemsSource = DayScheduleList;
            cbTuesday3.ItemsSource = DayScheduleList;
            cbWednesday3.ItemsSource = DayScheduleList;
            cbThursday3.ItemsSource = DayScheduleList;
            cbFriday3.ItemsSource = DayScheduleList;
            cbSaturday3.ItemsSource = DayScheduleList;
            cbSunday3.ItemsSource = DayScheduleList;
            cbMonday4.ItemsSource = DayScheduleList;
            cbTuesday4.ItemsSource = DayScheduleList;
            cbWednesday4.ItemsSource = DayScheduleList;
            cbThursday4.ItemsSource = DayScheduleList;
            cbFriday4.ItemsSource = DayScheduleList;
            cbSaturday4.ItemsSource = DayScheduleList;
            cbSunday4.ItemsSource = DayScheduleList;

        }

        private void RadioButton_Click_5(object sender, RoutedEventArgs e)
        {
            GWeek1.Visibility = Visibility.Visible;
            GWeek2.Visibility = Visibility.Visible;
            GWeek3.Visibility = Visibility.Visible;
            Gweek4.Visibility = Visibility.Visible;
            Gweek5.Visibility = Visibility.Visible;
            Gweek6.Visibility = Visibility.Collapsed;
            GStartWeek.Visibility = Visibility.Visible;
            string[] startweekarray = { "1", "2", "3", "4", "5" };

            cbstartweek.ItemsSource = startweekarray;
            cbMonday1.ItemsSource = DayScheduleList;
            cbTuesday1.ItemsSource = DayScheduleList;
            cbWednesday1.ItemsSource = DayScheduleList;
            cbThursday1.ItemsSource = DayScheduleList;
            cbFriday1.ItemsSource = DayScheduleList;
            cbSaturday1.ItemsSource = DayScheduleList;
            cbSunday1.ItemsSource = DayScheduleList;
            cbMonday2.ItemsSource = DayScheduleList;
            cbTuesday2.ItemsSource = DayScheduleList;
            cbWednesday2.ItemsSource = DayScheduleList;
            cbThursday2.ItemsSource = DayScheduleList;
            cbFriday2.ItemsSource = DayScheduleList;
            cbSaturday2.ItemsSource = DayScheduleList;
            cbSunday2.ItemsSource = DayScheduleList;
            cbMonday3.ItemsSource = DayScheduleList;
            cbTuesday3.ItemsSource = DayScheduleList;
            cbWednesday3.ItemsSource = DayScheduleList;
            cbThursday3.ItemsSource = DayScheduleList;
            cbFriday3.ItemsSource = DayScheduleList;
            cbSaturday3.ItemsSource = DayScheduleList;
            cbSunday3.ItemsSource = DayScheduleList;
            cbMonday4.ItemsSource = DayScheduleList;
            cbTuesday4.ItemsSource = DayScheduleList;
            cbWednesday4.ItemsSource = DayScheduleList;
            cbThursday4.ItemsSource = DayScheduleList;
            cbFriday4.ItemsSource = DayScheduleList;
            cbSaturday4.ItemsSource = DayScheduleList;
            cbSunday4.ItemsSource = DayScheduleList;
            cbMonday5.ItemsSource = DayScheduleList;
            cbTuesday5.ItemsSource = DayScheduleList;
            cbWednesday5.ItemsSource = DayScheduleList;
            cbThursday5.ItemsSource = DayScheduleList;
            cbFriday5.ItemsSource = DayScheduleList;
            cbSaturday5.ItemsSource = DayScheduleList;
            cbSunday5.ItemsSource = DayScheduleList;
        }

        private void RadioButton_Click_6(object sender, RoutedEventArgs e)
        {
            GWeek1.Visibility = Visibility.Visible;
            GWeek2.Visibility = Visibility.Visible;
            GWeek3.Visibility = Visibility.Visible;
            Gweek4.Visibility = Visibility.Visible;
            Gweek5.Visibility = Visibility.Visible;
            Gweek6.Visibility = Visibility.Visible;
            GStartWeek.Visibility = Visibility.Visible;
            string[] startweekarray = { "1", "2", "3", "4", "5","6" };

            cbstartweek.ItemsSource = startweekarray;
            cbMonday1.ItemsSource = DayScheduleList;
            cbTuesday1.ItemsSource = DayScheduleList;
            cbWednesday1.ItemsSource = DayScheduleList;
            cbThursday1.ItemsSource = DayScheduleList;
            cbFriday1.ItemsSource = DayScheduleList;
            cbSaturday1.ItemsSource = DayScheduleList;
            cbSunday1.ItemsSource = DayScheduleList;
            cbMonday2.ItemsSource = DayScheduleList;
            cbTuesday2.ItemsSource = DayScheduleList;
            cbWednesday2.ItemsSource = DayScheduleList;
            cbThursday2.ItemsSource = DayScheduleList;
            cbFriday2.ItemsSource = DayScheduleList;
            cbSaturday2.ItemsSource = DayScheduleList;
            cbSunday2.ItemsSource = DayScheduleList;
            cbMonday3.ItemsSource = DayScheduleList;
            cbTuesday3.ItemsSource = DayScheduleList;
            cbWednesday3.ItemsSource = DayScheduleList;
            cbThursday3.ItemsSource = DayScheduleList;
            cbFriday3.ItemsSource = DayScheduleList;
            cbSaturday3.ItemsSource = DayScheduleList;
            cbSunday3.ItemsSource = DayScheduleList;
            cbMonday4.ItemsSource = DayScheduleList;
            cbTuesday4.ItemsSource = DayScheduleList;
            cbWednesday4.ItemsSource = DayScheduleList;
            cbThursday4.ItemsSource = DayScheduleList;
            cbFriday4.ItemsSource = DayScheduleList;
            cbSaturday4.ItemsSource = DayScheduleList;
            cbSunday4.ItemsSource = DayScheduleList;
            cbMonday5.ItemsSource = DayScheduleList;
            cbTuesday5.ItemsSource = DayScheduleList;
            cbWednesday5.ItemsSource = DayScheduleList;
            cbThursday5.ItemsSource = DayScheduleList;
            cbFriday5.ItemsSource = DayScheduleList;
            cbSaturday5.ItemsSource = DayScheduleList;
            cbSunday5.ItemsSource = DayScheduleList;
            cbMonday6.ItemsSource = DayScheduleList;
            cbTuesday6.ItemsSource = DayScheduleList;
            cbWednesday6.ItemsSource = DayScheduleList;
            cbThursday6.ItemsSource = DayScheduleList;
            cbFriday6.ItemsSource = DayScheduleList;
            cbSaturday6.ItemsSource = DayScheduleList;
            cbSunday6.ItemsSource = DayScheduleList;
        }


        
    }
}
