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
using System.Windows.Navigation;
using System.Windows.Shapes;
using SendMessage.ViewModels;
using SystemAndersson.Anet.BI.LoginSQL;
using SystemAndersson.Anet.Production.Common;
using SystemAndersson.Anet.BI.Admin.Users;
using SystemAndersson.Anet.BI.Registry;
using SystemAndersson.Anet.BI.Message;
using SendMessage.Handlers;

namespace SendMessage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        SendViewModel wm;
        Message mess = new Message();
      
        public MainWindow()
        {
            InitializeComponent();
            Servers Conn = new Servers();
            Servers Conn2 = new Servers();
            //Connections.adminConnection = Conn.CreateConnection(@"Utv-Server\sqlexpress", "AnetAdmin");

            //Connections.companyConnection = Conn2.CreateConnection(@"Utv-Server\sqlexpress", "AnetCompany01");
            Connections.adminConnection = Conn.CreateConnection(@"ankal-win7x64\sqlexpress", "AnetAdmin");

            Connections.companyConnection = Conn2.CreateConnection(@"ankal-win7x64\sqlexpress", "AnetCompany01");
            UserData.Name="Andreas Käll";
            UserData.UserId = 5;
            wm = new SendViewModel(this);
            this.DataContext = wm;

            adminData.ItemsSource = wm.UserList;
            prodData.ItemsSource = wm.StaffList;
          

        

        }

        private void prodData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Staff staff = (Staff)prodData.SelectedItem;

            recipient.Text = staff.FullName;
            mess.Recipient = staff.FullName;
            mess.RecipientId = staff.StaffId;
            mess.RecipientType = 0;
            mess.Sender = UserData.Name;
            mess.SenderId = UserData.UserId;
            mess.SenderType = 1;
            mess.Readed = false;

        }

        private void adminData_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            User user = (User)adminData.SelectedItem;

            recipient.Text = user.FullName;
            mess.MessageHeadId = 0;
            mess.Recipient = user.FullName;
            mess.RecipientId = user.UserId;
            mess.RecipientType = 1;
            mess.Sender = UserData.Name;
            mess.SenderId = UserData.UserId;
            mess.SenderType = 1;
            mess.Readed = false;
        }

        private void btnSend_Click(object sender, RoutedEventArgs e)
        {
            MessageBoxResult result = MessageBox.Show("Vill du skicka meddelandet till " + mess.Recipient + "?", "Skicka meddelande", MessageBoxButton.YesNo);



            if (result == MessageBoxResult.Yes)
            {
                               
                mess.MessageText = tbMessageText.Text;
                mess.ReadDate = DateTime.Parse("1900-01-01");
                mess.SentDate = DateTime.Now;
                if (mess.MessageHeadId == 0)
                {
                    MessageHandler mhand = new MessageHandler();

                    mhand.SaveMessage(mess);
                }
                
                

               

                MessageBox.Show("Meddelandet är skickat");
                ClearMess();
            }

            else if (result == MessageBoxResult.No)
            {

                // No code here

            }




        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ReceiveWindow rc = new ReceiveWindow();
            rc.Show();
        }

     

        private void tabItem2_GotFocus(object sender, RoutedEventArgs e)
        {
           
            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
           
        }

       

        private void button1_Click_1(object sender, RoutedEventArgs e)
        {
            ClearMess();
           
        }

        private void ClearMess()
        {
            mess.MessageHeadId = 0;
            mess.MessageText = null;
            mess.ReadDate = DateTime.Parse("1900-01-01");
            mess.Readed = false;
            mess.Recipient = null;
            mess.RecipientId = 0;
            mess.RecipientType = 0;
            mess.Sender = null;
            mess.SenderId = 0;
            mess.SenderType = 0;
            mess.SentDate = DateTime.Parse("1900-01-01");
            recipient.Text = "Ange mottagare";
            tbMessageText.Text = null;
            
        
        }

        private void adminTab_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            User user = (User)adminData.SelectedItem;
            UserData.UserId = user.UserId;
            UserData.Name = user.FullName;
            MessageBox.Show("Bytt avsändare till " + UserData.Name);
            ClearMess();
        }

        private void button2_Click_1(object sender, RoutedEventArgs e)
        {
            ReceiveWindow rw = new ReceiveWindow();
            rw.Show();
        }


    }
}
