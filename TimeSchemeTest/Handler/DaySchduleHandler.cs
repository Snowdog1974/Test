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
    public class DayScheduleHandler
    {


        public void SaveDaySchedule(DaySchedule daySchedule, string Description)
        {
            try
            {
                Connections.companyConnection.Open();
                DayScheduleReg DayScheduleReg = new DayScheduleReg();
                DayScheduleReg.SaveDaySchedule(Connections.companyConnection, daySchedule);
                Connections.companyConnection.Close();
               
                if ( DayScheduleDescReg.CheckIfDescriptionExists(Connections.companyConnection, daySchedule.Id) == false)
                {
                    Connections.companyConnection.Open();
                    DayScheduleDescReg desc = new DayScheduleDescReg();
                    DayScheduleDesc daydesc = new DayScheduleDesc();
                    daydesc.Id=daySchedule.Id;
                    daydesc.Description=Description;
                    desc.SaveDayScheduleDesc(Connections.companyConnection, daydesc);
                    Connections.companyConnection.Close();
                }
                
            }
            catch (Exception e)
            {
               
                throw new ArgumentException(e.Message);
            }

            finally
            {
                //  Connections.companyConnection.Close();
            }

        }
        
        
        
        
        
        public ObservableCollection<DaySchedule> GetDaySchedule(int Id)
        {

            List<DaySchedule> DayScheduleList = DayScheduleReg.GetDaySchedule(Connections.companyConnection, Id);

           // return DayScheduleList;
            ObservableCollection<DaySchedule> oc = new ObservableCollection<DaySchedule>();

            if (DayScheduleList == null)
            {
                return oc;
            }
            else
            {
                NonParallelExtensions.AddRange(oc, DayScheduleList);
                return oc;
            }

        }

        public ObservableCollection<DayScheduleDesc> GetDayScheduleDesc()
        {

            List<DayScheduleDesc> DayScheduleDescList = DayScheduleDescReg.GetDayScheduleDesc(Connections.companyConnection);

            //return DayScheduleDescList;
            ObservableCollection<DayScheduleDesc> oc = new ObservableCollection<DayScheduleDesc>();

            if (DayScheduleDescList == null)
            {
                return oc;
            }
            else
            {
                NonParallelExtensions.AddRange(oc, DayScheduleDescList);
                return oc;
            }

        }

        public DayScheduleDesc GetDayScheduleDesc(int id)
        {
            DayScheduleDesc daydesc = DayScheduleDescReg.GetDayScheduleDesc(Connections.companyConnection,id);

            return daydesc;
           
        }

    }
}
