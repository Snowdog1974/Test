using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;
using SystemAndersson.Anet.BI.TimeSchedule;
using System.Windows;
using SystemAndersson.Anet.Common.UI;
using TimeSchemeTest.Handler;
using SystemAndersson.Anet.Production.Common;
using SystemAndersson.Anet.BI.LoginSQL;
using System.Collections.ObjectModel;

namespace TimeSchemeTest.ViewModel
{
    public class NewDayScheduleViewModel : ViewModelBaseAdmin, INotifyPropertyChanged
    {

        DateScheduleHandler DateH = new DateScheduleHandler();
        DayScheduleHandler DayH = new DayScheduleHandler();
        TimeCodeHandler TimeC = new TimeCodeHandler();

        public NewDayScheduleViewModel(Window aView)
            : base(aView)
        {
          
            
           
           
            dayScheduleDescList = DayH.GetDayScheduleDesc();
            dayScheduleList = new ObservableCollection<DaySchedule>();
            timeCodeList = TimeC.GetTimeCode();
           
        }

      


        public ObservableCollection<DaySchedule> UpdateDayScheduleList(int id)
        {
            return DayH.GetDaySchedule(id);
        }

        public DayScheduleDesc GetDayScheduleDesc(int id)
        {
            return DayH.GetDayScheduleDesc(id);
        }




        protected ObservableCollection<DateScheduleDesc> dateScheduleDescList;

        public ObservableCollection<DateScheduleDesc> DateScheduleDescList
        {
            get { return dateScheduleDescList; }
            set 
            { 
                dateScheduleDescList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DateScheduleDescList"));
            }
        }

        protected ObservableCollection<DateSchedule> dateScheduleList;

        public ObservableCollection<DateSchedule> DateScheduleList
        {
            get { return dateScheduleList; }
            set
            {
                dateScheduleList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DateScheduleList"));
            }
        }

        protected ObservableCollection<TimeCode> timeCodeList;

        public ObservableCollection<TimeCode> TimeCoceList
        {
            get { return timeCodeList; }
            set
            {
                timeCodeList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("TimeCodeList"));
            }
        }

        protected ObservableCollection<DayScheduleDesc> dayScheduleDescList;

        public ObservableCollection<DayScheduleDesc> DayScheduleDescList
        {
            get { return dayScheduleDescList; }
            set
            {
                dayScheduleDescList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DayScheduleDescList"));
            }
        }

        protected ObservableCollection<DaySchedule> dayScheduleList;

        public ObservableCollection<DaySchedule> DayScheduleList
        {
            get { return dayScheduleList; }
            set
            {
                dayScheduleList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DayScheduleList"));
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }
    
}
