using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using SystemAndersson.Anet.BI.Admin.Users;
using SystemAndersson.Anet.Production.Common;
using SystemAndersson.Anet.BI.Registry;


namespace SendMessage.Handlers
{
    public class UserHandler
    {
        public List<User> GetUsers()
        {

            List<User> UserList = UserReg.GetUsers(Connections.adminConnection);

            return UserList;
           // ObservableCollection<User> oc = new ObservableCollection<User>();

            //if (UserList == null)
            //{
            //    return oc;
            //}
            //else
            //{
            //    NonParallelExtensions.AddRange(oc, UserList);
            //    return oc;
            //}

        }


        public List<Staff> GetStaff()
        {

            List<Staff> StaffList = StaffReg.GetActiveStaff(Connections.companyConnection);

            return StaffList;
            // ObservableCollection<User> oc = new ObservableCollection<User>();

            //if (UserList == null)
            //{
            //    return oc;
            //}
            //else
            //{
            //    NonParallelExtensions.AddRange(oc, UserList);
            //    return oc;
            //}

        }
    
    }
}
