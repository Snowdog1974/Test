using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemAndersson.Anet.BI.TimeSchedule;
using SystemAndersson.Anet.Production.Common;
using System.Collections.ObjectModel;
using SystemAndersson.Anet.BI.Utilities;

namespace TimeSchemeTest.Handler
{
    public class DateScheduleHandler
    {

        public ObservableCollection<DateSchedule> GetDateSchedule(int Id, DateTime Fromdate, DateTime Todate)
        {

            List<DateSchedule> DateScheduleList = DateScheduleReg.GetDateSchedule(Connections.companyConnection, Id, Fromdate, Todate);

            //return DateScheduleList;
            ObservableCollection<DateSchedule> oc = new ObservableCollection<DateSchedule>();

            if (DateScheduleList == null)
            {
                return oc;
            }
            else
            {
                NonParallelExtensions.AddRange(oc, DateScheduleList);
                return oc;
            }

        }

        public ObservableCollection<DateScheduleDesc> GetDateScheduleDesc()
        {

            List<DateScheduleDesc> DateScheduleDescList = DateScheduleDescReg.GetDateScheduleDesc(Connections.companyConnection);

           // return DateScheduleDescList;
            ObservableCollection<DateScheduleDesc> oc = new ObservableCollection<DateScheduleDesc>();

            if (DateScheduleDescList == null)
            {
                return oc;
            }
            else
            {
                NonParallelExtensions.AddRange(oc, DateScheduleDescList);
                return oc;
            }

        }
    }
}
