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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SystemAndersson.Anet.ServiceHost.Win;
using System.Data;
using SystemAndersson.Anet.Common.Contract;
using TimeSchemeTest.ViewModel;
using SystemAndersson.Anet.BI.LoginSQL;
using SystemAndersson.Anet.Production.Common;
using SystemAndersson.Anet.BI.TimeSchedule;
using System.ComponentModel;

namespace TimeSchemeTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        MainViewModel wm;

        public MainWindow()
        {
            InitializeComponent();
            Servers Conn = new Servers();
            Connections.companyConnection = Conn.CreateConnection(@"Utv-server\sqlexpress", "AnetCompany02");
            
            wm = new MainViewModel(this);
            this.DataContext = wm;
            
            dataGrid1.ItemsSource = wm.DateScheduleDescList;
            dataGrid3.ItemsSource = wm.DayScheduleDescList;
           
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            TWinTerminalService srv = new TWinTerminalService();
            srv.Initialize(@"UTV-Server\SQLEXPRESS", "AnetCompany02", "Andersson", "andersson");
            TDateScheduleItemSvcRec item = new TDateScheduleItemSvcRec();
          
            TDateScheduleSvcRec dateschedule = new TDateScheduleSvcRec();
            //dateschedule.DateSchedules=;
            //DataTable stamplist = 
            TUserDayInfoSvcRec userinfo= srv.GetUserDayStatus(16);
        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DateScheduleDesc ds= (DateScheduleDesc)dataGrid1.SelectedItem;
            dataGrid2.ItemsSource = wm.UpdateDateScheduleList(ds.Id, DateTime.Parse("2012-06-01"), DateTime.Parse("2012-06-30"));
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        private void dataGrid3_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            DayScheduleDesc ds = (DayScheduleDesc)dataGrid3.SelectedItem;
            dataGrid4.ItemsSource = wm.UpdateDayScheduleList(ds.Id);
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            NewDaySchedule news = new NewDaySchedule();
            news.Show();
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            NewDateSchedule news = new NewDateSchedule();
            news.Show();
        }

       

    }
}
