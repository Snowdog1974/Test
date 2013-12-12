using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace SendMessage
{
    public class MessageControl
    {

    }


    public class MessageList : List<MessageHead>
    {
    }
    public class MessageHead : INotifyPropertyChanged
    {

        public MessageHead()
        {

        }

        public MessageHead(long messageHeadId, string recipient, long recipientId, int recipientType, bool readed, DateTime readDate, string sender, long senderId, int senderType, DateTime sentDate, string message)
        {
            MessageHeadId = messageHeadId;
            Recipient = recipient;
            RecipientId = recipientId;
            RecipientType = recipientType;
            Readed = readed;
            ReadDate = readDate;
            Sender = sender;
            SenderId = senderId;
            SenderType = senderType;
            SentDate = sentDate;
            Message = message;
        }

        private long messageHeadId;
        public long MessageHeadId
        {
            get { return messageHeadId; }
            set
            {
                messageHeadId = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MessageHeadId"));
            }
        }

        private string recipient;
        public string Recipient
        {
            get { return recipient; }
            set
            {
                recipient = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Recipient"));
            }
        }

        private long recipientId;
        public long RecipientId
        {
            get { return recipientId; }
            set
            {
                recipientId = value;
                OnPropertyChanged(new PropertyChangedEventArgs("RecipientId"));
            }
        }

        private int recipientType;
        public int RecipientType
        {
            get { return recipientType; }
            set
            {
                recipientType = value;
                OnPropertyChanged(new PropertyChangedEventArgs("RecipientType"));
            }
        }

        private bool readed;
        public bool Readed
        {
            get { return readed; }
            set
            {
                readed = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Readed"));
            }
        }

        private string sender;
        public string Sender
        {
            get { return sender; }
            set
            {
                sender = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Sender"));
            }
        }

        private long senderId;
        public long SenderId
        {
            get { return senderId; }
            set
            {
                senderId = value;
                OnPropertyChanged(new PropertyChangedEventArgs("SenderId"));
            }
        }

        private int senderType;
        public int SenderType
        {
            get { return senderType; }
            set
            {
                senderType = value;
                OnPropertyChanged(new PropertyChangedEventArgs("SenderType"));
            }
        }


        private DateTime sentDate;
        public DateTime SentDate
        {
            get { return sentDate; }
            set
            {
                sentDate = value;
                OnPropertyChanged(new PropertyChangedEventArgs("SentDate"));
            }
        }

        private DateTime readDate;
        public DateTime ReadDate
        {
            get { return readDate; }
            set
            {
                readDate = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ReadDate"));
            }
        }

        private string message;
        public string Message
        {
            get { return message; }
            set
            {
                message = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Message"));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

    }



    public class MessageDetails : INotifyPropertyChanged
    {

        public MessageDetails()
        {

        }

        public MessageDetails(long messageDetailsId, long messageHeadId, string messageText)
        {
            MessageDetailsId = messageDetailsId;
            MessageHeadId = messageHeadId;
            MessageText = messageText;
           
        }

        private long messageDetailsId;
        public long MessageDetailsId
        {
            get { return messageDetailsId; }
            set
            {
                messageDetailsId = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MessageDetailsId"));
            }
        }
        
        private long messageHeadId;
        public long MessageHeadId
        {
            get { return messageHeadId; }
            set
            {
                messageHeadId = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MessageHeadId"));
            }
        }

        private string messageText;
        public string MessageText
        {
            get { return messageText; }
            set
            {
                messageText = value;
                OnPropertyChanged(new PropertyChangedEventArgs("MessageText"));
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


