using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using SystemAndersson.Anet.BI.Admin.Users;
using System.Windows;
using SystemAndersson.Anet.Production.UI;
using System.ComponentModel;
using SendMessage.Handlers;
using SystemAndersson.Anet.BI.Registry;
using SystemAndersson.Anet.BI.Message;
using SystemAndersson.Anet.Production.Common;


namespace SendMessage.ViewModels
{
    public class SendViewModel : ViewModelBaseAdmin, INotifyPropertyChanged
    {
        protected List<User> userList;
        
        

        public List<User> UserList
        {
            get { return userList; }
            set 
            { 
                userList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("UserList"));
            }
        }

        UserHandler UH = new UserHandler();
        MessageHandler MH = new MessageHandler();

        protected List<Staff> staffList;



        public List<Staff> StaffList
        {
            get { return staffList; }
            set
            {
                staffList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("StaffList"));
            }
        }

        protected List<Message> messageList;



        public List<Message> MessageList
        {
            get { return messageList; }
            set
            {
                messageList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MessageList"));
            }
        }

        protected List<Message> sentMessageList;



        public List<Message> SentMessageList
        {
            get { return sentMessageList; }
            set
            {
                sentMessageList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("SentMessageList"));
            }
        }

        protected List<Message> readMessageList;



        public List<Message> ReadMessageList
        {
            get { return readMessageList; }
            set
            {
                readMessageList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ReadMessageList"));
            }
        }

        public SendViewModel(Window aView)
            : base(aView)
        {
            userList = UH.GetUsers();
            staffList = UH.GetStaff();
            messageList=MH.GetMessages();
            readMessageList =MH.GetMessages(true);
            sentMessageList = MH.GetSentMessages(UserData.UserId);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }


        public void UpdateMessages(long staffid)
        {
            MessageList = MH.GetMessages(staffid,false);
            ReadMessageList = MH.GetMessages(staffid,true);
            SentMessageList = MH.GetSentMessages(staffid);
        }

        public void UpdateMessages()
        {
            MessageList = MH.GetMessages(false);
            ReadMessageList = MH.GetMessages(true);
            SentMessageList = MH.GetSentMessages(UserData.UserId);

        }

        public void UpdateUserData(long Userid, string Name)
        {
            UserData.UserId = Userid;
            UserData.Name = Name;
        }

    }
}
