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
using SystemAndersson.Anet.BI.Message;
using SendMessage.ViewModels;
using SendMessage.Handlers;

namespace SendMessage
{
    /// <summary>
    /// Interaction logic for ReceiveWindow.xaml
    /// </summary>
    public partial class ReceiveWindow : Window
    {
        SendViewModel wm;
        public ReceiveWindow()
        {
            InitializeComponent();
            wm = new SendViewModel(this);
            this.DataContext = wm;
            wm.UpdateMessages();
            InboxData.ItemsSource = wm.MessageList;
            ReadData.ItemsSource = wm.ReadMessageList;
            SentData.ItemsSource = wm.SentMessageList;
        }

       

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InboxData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Message m = (Message)InboxData.SelectedItem;
            MessageBox1.Text = m.MessageText;
            textBlock1.Text = m.Sender;
        }


        private void ReadData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Message m = (Message)ReadData.SelectedItem;
            MessageBox1.Text = m.MessageText;
            textBlock1.Text = m.Sender;
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            Message m = (Message)InboxData.SelectedItem;
            m.Readed = true;
            m.ReadDate = DateTime.Now;
            MessageHandler mh = new MessageHandler();
            mh.SaveMessage(m);
            wm.UpdateMessages();
        }

        private void SentData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Message m = (Message)SentData.SelectedItem;
            MessageBox1.Text = m.MessageText;
            textBlock1.Text = m.Sender;
        }

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
