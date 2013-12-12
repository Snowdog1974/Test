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
using System.Windows.Shapes;
using TimeSchemeTest.ViewModel;

using System.ComponentModel;
using TimeSchemeTest.Handler;
using SystemAndersson.Anet.BI.TimeSchedule;

namespace TimeSchemeTest
{
    /// <summary>
    /// Interaction logic for NewDaySchedule.xaml
    /// </summary>
    public partial class NewDaySchedule : Window, INotifyPropertyChanged
    {
        NewDayScheduleViewModel wm;
        DayScheduleHandler DayHandler = new DayScheduleHandler();
        public NewDaySchedule()
        {
            InitializeComponent();
             wm = new NewDayScheduleViewModel(this);
            this.DataContext = wm;
            comboBox1.ItemsSource = wm.TimeCoceList;
            
        }

        private void textBox1_LostFocus(object sender, RoutedEventArgs e)
        {
            if (textBox1.Text!="")
            {
               dataGrid1.ItemsSource = wm.UpdateDayScheduleList(Convert.ToInt32(textBox1.Text));
               DayScheduleDesc desc = wm.GetDayScheduleDesc(Convert.ToInt32(textBox1.Text));
               textBox4.Text = desc.Description;
            }
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
           TimeCode tc= (TimeCode)comboBox1.SelectedItem;
            DaySchedule ds = new DaySchedule(0,Convert.ToInt32(textBox1.Text),textBox2.Text,textBox3.Text,tc.Id,1,tc.Description, DateTime.Now);
          
            DayHandler.SaveDaySchedule(ds,textBox4.Text);
            wm.DayScheduleList.Add(ds);
            dataGrid1.ItemsSource = wm.DayScheduleList;
          
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }
}
