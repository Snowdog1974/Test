using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using SystemAndersson.Anet.BI.TimeSchedule;
using SystemAndersson.Anet.Production.Common;
using SystemAndersson.Anet.BI.Utilities;

namespace TimeSchemeTest.Handler
{
   public class TimeCodeHandler
    {
       public ObservableCollection<TimeCode> GetTimeCode()
       {

           List<TimeCode> TimeCodeList = TimeCodeReg.GetTimeCodes(Connections.companyConnection);

           // return DayScheduleList;
           ObservableCollection<TimeCode> oc = new ObservableCollection<TimeCode>();

           if (TimeCodeList == null)
           {
               return oc;
           }
           else
           {
               NonParallelExtensions.AddRange(oc, TimeCodeList);
               return oc;
           }

       }
    }
}
