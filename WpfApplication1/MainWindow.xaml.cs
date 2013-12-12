using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SystemAndersson.Anet.BI.Admin.ErrorLog;
using SystemAndersson.Anet.BI.LoginSQL;
using SystemAndersson.Anet.BI.Todo;
using SystemAndersson.Anet.Production.Common;

namespace WpfApplication1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        ToDoStaffList t = new ToDoStaffList();
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            Servers Conn = new Servers();
            Connections.companyConnection = Conn.CreateConnection(@"Utv-server\sqlexpress", "AnetAdmin");


            ErrorLogList list = ErrorLogReg.GetErrors(Connections.companyConnection, DateTime.Now.Subtract(new TimeSpan(1,0,0,0)), DateTime.Now);
            //File.WriteAllLines(@"c:\temp\foo.txt", list.ConvertAll(Convert.ToString));
             List<string> l = new List<string>();
            foreach (ErrorLog item in list)
	        {
                string i = item.ErrorDate + " " + item.Type + " " + item.UserId.ToString() + " " + item.FullName + " " + item.MachineName + " " + item.ErrorMessage + " " + item.Error + " " + item.CompanyName + " " + item.CompanyDescription + " " + item.StackTrace;    
	        l.Add(i);
            l.Add("");
            }
           
            
            
            File.WriteAllLines(@"c:\temp\foo.txt", l);

           
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add("karl.moestedt@systemandersson.se");
            message.Subject = "Logg från CompanyName";
            message.From = new System.Net.Mail.MailAddress("jagharensladd@gmail.com");
            message.Body = "Bifogar logg från Anet Planering";
            message.Attachments.Add(new System.Net.Mail.Attachment("c:/temp/foo.txt"));
            const string fromPassword = "V70szx317";
            System.Net.Mail.SmtpClient smtp = new SmtpClient
            {
                Host = "smtp.gmail.com",
                Port = 587,
                EnableSsl = true,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(message.From.Address, fromPassword),
                Timeout=20000
            };
            
            
           
            smtp.Send(message);
            

            MessageBox.Show("Klart ");


            //var fromAddress = new MailAddress("from@gmail.com", "From Name");
            //var toAddress = new MailAddress("to@example.com", "To Name");
            
          
           
            

        }

        private void dpstartdate_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            DateTime dt;
            DatePicker dp = (sender as DatePicker);
            string currentText = (e.OriginalSource as TextBox).Text;
            
            if (!DateTime.TryParse(currentText, out dt))
            {
                try
                {
                    string month="";
                    string day="";
                    string year=""; 
                    if (currentText.Length == 8)
                    {
                        month = currentText.Substring(4, 2);
                        day = currentText.Substring(6, 2);
                        year = currentText.Substring(0, 4);
                    }
                    else if (currentText.Length == 6)
                    {
                        month = currentText.Substring(2, 2);
                        day = currentText.Substring(4, 2);
                        year = currentText.Substring(0, 2);
                        year = "20" + year;
                    }
                    dt = new DateTime(int.Parse(year), int.Parse(month), int.Parse(day));
                    dp.SelectedDate = dt;
                }
                catch (Exception ex)
                {
                    dp.SelectedDate = null;
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

            Servers Conn = new Servers();
            Connections.companyConnection = Conn.CreateConnection(@"Utv-server\sqlexpress", "AnetCompany02");


            for (int i = 0; i < 100; i++)
            {
                t = ToDoStaffReg.GetNotIn(Connections.companyConnection);
            }

            MessageBox.Show("Klart ");
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            System.Net.Mail.MailMessage message = new System.Net.Mail.MailMessage();
            message.To.Add("karl.moestedt@systemandersson.se");
            message.Subject = "Logg från CompanyName";
            message.From = new System.Net.Mail.MailAddress("andreas.kall@systemandersson.se");
            message.Body = "Bifogar logg från Anet Planering";
            message.Attachments.Add(new System.Net.Mail.Attachment("c:/temp/foo.txt"));
            
            System.Net.Mail.SmtpClient smtp = new System.Net.Mail.SmtpClient("Smtp.bredband.net");
            smtp.Send(message);
            MessageBox.Show("Skickat");
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
              Servers Conn = new Servers();
            Connections.companyConnection = Conn.CreateConnection(@"Utv-server\sqlexpress", "AnetAdmin");
            
            ErrorLogReg el = new ErrorLogReg();
            if (el.SendErrorLog(Connections.companyConnection, "anetaktivtit@gmail.com", "!Selma?80", "SystemAndersson testbolag", @"c:\temp\","Test customer", 200000) == true)
            {
                MessageBox.Show("Skickat");
            }
            else
            {
                MessageBox.Show("något gick fel");
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            RunProcess();
        }


        private void RunProcess()
        {
        string FileName = "SQLCMD";
        //string Arguments = @"-S utv-server\SQLexpress -d AnetCompany02 -U andersson -P andersson -Q ""SELECT * FROM Article WHERE [CreditRating] >= 3 "" -s "","" -o ""c:\temp\VendorResults.csv""";
        string Arguments2;
        Arguments2 = @"-S utv-server\SQLexpress -d AnetCompany02 -U andersson -P andersson -Q ""SELECT * FROM ApplicationLog "" -s "","" -o ""c:\temp\TLog.csv""";
        string t3 = Arguments2;
        DateTime d = DateTime.Parse("2013-01-01");
        DateTime e = DateTime.Parse("2013-01-31");

        string sql="SELECT * FROM ApplicationLog  where [LogTime] >= "+ d +" and [LogTime] =< "+ e +""+"";
        string arg1=@"-S utv-server\SQLexpress -d AnetCompany02 -U andersson -P andersson -Q """;
        string arg2=@""" -s """;
        //string arg3=" -s ""+','+"" -o ""+c:\temp\TLog.csv+"""";
        string Arguments = arg1+sql;
        ProcessStartInfo proc = new ProcessStartInfo(FileName, Arguments);
        proc.UseShellExecute = false;
        proc.CreateNoWindow = true;
        proc.WindowStyle = ProcessWindowStyle.Hidden;

        Process p = new Process();
        p.StartInfo = proc;

        p.Start();
        p.WaitForExit();
        MessageBox.Show("Klart");
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Servers Conn = new Servers();
            Connections.companyConnection = Conn.CreateConnection(@"Utv-server\sqlexpress", "AnetCompany02");

            ErrorLogReg el = new ErrorLogReg();
            if (el.SendTerminalLog(Connections.companyConnection, "AnetCompany02", @"UTV-server\sqlexpress", "anetaktivtit@gmail.com", "!Selma?80", "SystemAndersson testbolag", 200000) == true)
            {
                MessageBox.Show("Skickat");
            }
            else
            {
                MessageBox.Show("något gick fel");
            }
        }
    }
}
