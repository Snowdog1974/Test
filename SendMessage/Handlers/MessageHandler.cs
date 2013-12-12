using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;
using SystemAndersson.Anet.BI.Admin.Users;
using SystemAndersson.Anet.Production.Common;
using SystemAndersson.Anet.BI.Registry;
using SystemAndersson.Anet.BI.Message;


namespace SendMessage.Handlers
{
    public class MessageHandler
    {

        public MessageHandler()
        {

        }

        public List<Message> GetMessages()
        {

            List<Message> MessageList = MessageReg.GetMessagesOnRecipientId(Connections.companyConnection,UserData.UserId);

            return MessageList;
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


        public List<Message> GetMessages(long StaffId)
        {

            List<Message> MessageList = MessageReg.GetMessagesOnRecipientId(Connections.companyConnection, StaffId);

            return MessageList;
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

        public List<Message> GetMessages(long StaffId, bool Readed)
        {

            List<Message> MessageList = MessageReg.GetMessagesOnRecipientIdReaded(Connections.companyConnection, StaffId,1, Readed, DateTime.Parse("2011-12-01"));

            return MessageList;
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

        public List<Message> GetMessages(bool Readed)
        {

            List<Message> MessageList = MessageReg.GetMessagesOnRecipientIdReaded(Connections.companyConnection, UserData.UserId,1, Readed, DateTime.Parse("2011-12-01"));

            return MessageList;
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

        public List<Message> GetSentMessages(long SenderId)
        {

            List<Message> MessageList = MessageReg.GetMessagesOnSenderId(Connections.companyConnection, SenderId,1, DateTime.Parse("2011-12-01"));

            return MessageList;
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

        public void SaveMessage(Message message)
        {
            try
            {
                Connections.companyConnection.Open();
                MessageReg MessReg = new MessageReg();
                MessReg.SaveMessage(Connections.companyConnection, message);

            }
            catch (Exception e)
            {
                
                throw new ArgumentException(e.Message);
            }

            finally
            {
                Connections.companyConnection.Close();
            }

        }
    
    }
}
