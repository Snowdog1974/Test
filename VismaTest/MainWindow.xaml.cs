using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using SystemAndersson.Anet.BI.LoginSQL;
using SystemAndersson.Anet.BI.Settings;
using SystemAndersson.Anet.Integration.VismaAdminIntegration;
using SystemAndersson.Anet.Production.Common;

namespace VismaTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //VismaAdminIntegration runner = new VismaAdminIntegration();
        SqlConnection Conn = new SqlConnection();
        public string CommonFilesPath = @"C:\ProgramData\SPCS\SPCS Administration\Gemensamma filer\";
        public string CompanyPath = @"C:\ProgramData\SPCS\SPCS Administration\Foretag\Ovnbol2000";

        //public string CommonFilesPath = @"C:\Documents and Settings\All Users\Application Data\SPCS\SPCS Administration\Gemensamma filer";
        //public string CompanyPath = @"C:\Documents and Settings\All Users\Application Data\SPCS\SPCS Administration\Foretag\Ovnbol2000";
        //public string CommonFilesPath = "";
        //public string CompanyPath = "";
        public string folderPath = @"c:\temp";
        public string defaultSupplier;
        public bool UseLog;
        public bool UseSortNotion;
        public bool ExportArticles;
        public bool ImportArticles;
        public bool ExportSuppliers;
        public bool ImportSuppliers;
        public bool ExportCustomers;
        public bool ImportCustomers;
        public bool ImportOrder;
        public string Server;
        public string Company;
        public int VismaAdmin;
        public int VismaMamut;

        
        public MainWindow()
        {
            InitializeComponent();
            lBox.ItemsSource = GetAnetServices();
            Thread.CurrentThread.CurrentUICulture = new CultureInfo("sv-SE");
        }

        public bool SetDefaultServer(string ServerName, string CompanyName, int VismaAdministration, string CommonFilePath, string CompanyFilesPath)
        {
             RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\SystemAndersson\BuisnessIntergrationService", true);
             if (registryKey == null)
             {
                 Microsoft.Win32.RegistryKey key = Microsoft.Win32.Registry.LocalMachine.OpenSubKey("SOFTWARE", true);
                 key.CreateSubKey(@"SystemAndersson");
                 key = key.OpenSubKey(@"SystemAndersson", true);


                 key.CreateSubKey(@"BuisnessIntergrationService");
                 key = key.OpenSubKey(@"BuisnessIntergrationService", true);

                

                 key.SetValue("Server", (string)ServerName, RegistryValueKind.String);
                 key.SetValue("CompanyName", (string)CompanyName, RegistryValueKind.String);
                 key.SetValue("VismaAdministration", (int)VismaAdministration, RegistryValueKind.DWord);
                 key.SetValue("VismaMamut", (int)VismaMamut, RegistryValueKind.DWord);

                 key.CreateSubKey(@"VismaAdminIntergration");
                 key = key.OpenSubKey(@"VismaAdminIntergration", true);
                 key.SetValue("CommonFilesPath", (string)CommonFilePath, RegistryValueKind.String);
                 key.SetValue("CompanyFilesPath", (string)CompanyFilesPath, RegistryValueKind.String);

                 key.Close();
             }
             else
             {
                 
                 Server = (string)registryKey.GetValue("Server");
                 Company = (string)registryKey.GetValue("CompanyName");
                 VismaAdmin = (int)registryKey.GetValue("VismaAdministration");
                 VismaMamut = (int)registryKey.GetValue("VismaMamut");

                 registryKey = registryKey.OpenSubKey(@"VismaAdminIntergration", true);
                 CommonFilesPath = (string)registryKey.GetValue("CommonFilesPath");
                 CompanyPath = (string)registryKey.GetValue("CompanyFilesPath");

                 if (Server != ServerName || Company != CompanyName)
                 {
                     RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\SystemAndersson\BuisnessIntergrationService", true);
                     regKey.SetValue("Server", (string)ServerName, RegistryValueKind.String);
                     regKey.SetValue("CompanyName", (string)CompanyName, RegistryValueKind.String);
                     regKey.SetValue("VismaAdministration", (int)VismaAdministration, RegistryValueKind.DWord);
                     regKey.SetValue("VismaMamut", (int)VismaMamut, RegistryValueKind.DWord);
                     regKey.Close();
                 }

                 if (CommonFilesPath != CommonFilePath || CompanyPath != CompanyFilesPath)
                 {
                     RegistryKey regKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\SystemAndersson\BuisnessIntergrationService\VismaAdminIntegration", true);
                     regKey.SetValue("CommonFilesPath", (string)CommonFilePath, RegistryValueKind.String);
                     regKey.SetValue("CompanyFilesPath", (string)CompanyFilesPath, RegistryValueKind.String);
                     regKey.Close();
                  
                 }



             }

            return true;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            
             try
             {

                // SetDefaultServer(@"UTV-Server\SQLEXPRESS", "AnetCompany02", 1, @"C:\ProgramData\SPCS\SPCS Administration\Gemensamma filer\",@"C:\ProgramData\SPCS\SPCS Administration\Företag\Ovnbol2000");

                


                 RegistryKey registryKey = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\SystemAndersson\BuisnessIntergrationService", true);
                 if (registryKey != null)
                 {
                     Server = (string)registryKey.GetValue("Server");
                     Company = (string)registryKey.GetValue("CompanyName");
                     VismaAdmin = (int)registryKey.GetValue("VismaAdministration");
                     VismaMamut = (int)registryKey.GetValue("VismaMamut");

                     


                 }
                 else
                 {
                     RegistryKey registryKey2 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\SystemAndersson\BuisnessIntergrationService", true);
                     if (registryKey != null)
                     {
                         Server = (string)registryKey2.GetValue("Server");
                         Company = (string)registryKey2.GetValue("CompanyName");
                         VismaAdmin = (int)registryKey.GetValue("VismaAdministration");
                         VismaMamut = (int)registryKey.GetValue("VismaMamut");

                        

                     }
                     else
                     {
                         MessageBox.Show("Kunde inte läsa inställningar från registret");
                         Application.Current.Shutdown();
                     }
                   
                 }


                 
                
                 RegistryKey registry2Key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\SystemAndersson\BuisnessIntergrationService\VismaAdminIntergration", true);
                 if (registry2Key != null)
                 {
                     CommonFilesPath = (string)registry2Key.GetValue("CommonFilesPath");
                     CompanyPath = (string)registry2Key.GetValue("CompanyFilesPath");

                 }
                 else
                 {
                     RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\SystemAndersson\BuisnessIntergrationService\VismaAdminIntergration", true);
                     if (registryKey3 != null)
                     {
                         CommonFilesPath = (string)registryKey3.GetValue("CommonFilesPath");
                         CompanyPath = (string)registryKey3.GetValue("CompanyFilesPath");

                     }
                     else
                     {
                         MessageBox.Show("Kunde inte läsa inställningar från registret");
                         Application.Current.Shutdown();
                     }

                 }


                 Servers servA = new Servers();
                 Servers serv = new Servers();

                 

                 Conn=serv.CreateConnection(Server,Company);
                 Connections.adminConnection = servA.CreateConnection(Server, "AnetAdmin");
                 

                 

                 SyncServiceSettings SSS = new SyncServiceSettings();
                 SSS = SettingsReg.GetSettings(Conn, 8, SSS);
                
                 
                 folderPath = SSS.PathToLogFiles;
                 UseLog =SSS.UseLog;
                 UseSortNotion=SSS.UseSortNotion;
                 ExportArticles=SSS.ExportArticles;
                 ImportArticles=SSS.ImportArticles;
                 ExportSuppliers=SSS.ExportSuppliers;
                 ImportSuppliers=SSS.ImportSuppliers;
                 ExportCustomers=SSS.ExportCustomers;
                 ImportCustomers=SSS.ImportCustomers;
                 ImportOrder=SSS.ImportOrder;


                 FileStream fst = new FileStream(folderPath + "\\SystemAnderssonBuisnessIntegrationService.txt", FileMode.OpenOrCreate, FileAccess.Write);
                 StreamWriter mt_streamWriter = new StreamWriter(fst);
                 mt_streamWriter.BaseStream.Seek(0, SeekOrigin.End);

                 mt_streamWriter.WriteLine(" SystemAnderssonBuisnessIntegrationService: VismaAdminService " + CompanyPath + " at " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n");
                 mt_streamWriter.WriteLine(" SystemAnderssonBuisnessIntegrationService: VismaAdminService " + CommonFilesPath + " at " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n");
                 mt_streamWriter.Flush();
                 mt_streamWriter.Close();
             }
             catch (Exception ex)
             {
                 FileStream fst = new FileStream(folderPath + "\\SystemAnderssonBuisnessIntegrationService.txt", FileMode.OpenOrCreate, FileAccess.Write);
                 StreamWriter mt_streamWriter = new StreamWriter(fst);
                 mt_streamWriter.BaseStream.Seek(0, SeekOrigin.End);
                 mt_streamWriter.WriteLine(" SystemAnderssonBuisnessIntegrationService: VismaAdminService " + Common.GetCurrentMethod() + " " + ex.Message + " at " + DateTime.Now.ToShortDateString() + " " + DateTime.Now.ToShortTimeString() + "\n");
                 mt_streamWriter.Flush();
                 mt_streamWriter.Close();
             }


             VismaAdminIntegration runner = new VismaAdminIntegration(@"c:\Temp\");
             runner.OpenVismaConnection(CommonFilesPath, CompanyPath, Conn);
            //Klara
             //runner.SyncVismaArtToAProd(UseLog);
             //runner.SyncVismaCustomerToAProd(false, UseLog);
             //runner.SyncVismaSupplierToAProd(false, UseLog);
             runner.SyncAProdToVismaCustomer(false, UseLog);
            runner.SyncAProdToVismaSupplier(false, UseLog);
             //runner.SyncAProdToVismaArt(false, defaultSupplier);
             //runner.ImportOrderFromVismaAdmin(UseLog);
            //Ej Klara


            

             runner.GetUnitCodes(UseLog);
           
           
 


            runner.CloseVismaConnection();
            MessageBox.Show("Klart");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //double updatemilli = new TimeSpan(0, 50, 0).TotalMilliseconds;
            //MessageBox.Show(updatemilli.ToString());

         
            //MessageBox.Show(IsServiceInstalled("SystemAnderssonBuisnessIntegrationService").ToString());
            //StartService("SystemAnderssonBuisnessIntegrationService", 100000, "ANKAL-WIN8X64");
            // StartService("SystemAnderssonBuisnessIntegrationService", 100000, "192.168.10.130");
            //StartService("SystemAnderssonBuisnessIntegrationService", 100000);
            //TestService("SystemAnderssonBuisnessIntegrationService");
            if (lBox.SelectedItem != null)
            {
                ServiceController sc = (ServiceController)lBox.SelectedItem;
                StartService(sc.ServiceName, 100000);
            }
        }

        public static IEnumerable<ServiceController> GetAnetServices(string machineName)
        {
            // get list of Windows services
            ServiceController[] services = ServiceController.GetServices(machineName);

            return services.Where(a => a.ServiceName.StartsWith("SystemAndersson"));
        }

        public static IEnumerable<ServiceController> GetAnetServices()
        {
            // get list of Windows services
            ServiceController[] services = ServiceController.GetServices();

            return services.Where(a => a.ServiceName.StartsWith("SystemAndersson"));
        }


        public static bool IsServiceInstalled(string serviceName)
        {
            // get list of Windows services
            ServiceController[] services = ServiceController.GetServices();

            // try to find service name
            foreach (ServiceController service in services)
            {
                if (service.ServiceName == serviceName)
                    return true;
            }
            return false;
        }

        public static void TestService(string serviceName)
        {
            // get list of Windows services
            ServiceController service = new ServiceController(serviceName);
            MessageBox.Show(service.Status.ToString());
            //MessageBox.Show(service.Site.ToString());
            MessageBox.Show(service.ServiceType.ToString());
            //MessageBox.Show(service.ServiceHandle.ToString());
           
           
        }


        public static void StartService(string serviceName, int timeoutMilliseconds, string machineName)
        {
            ServiceController service = new ServiceController(serviceName,machineName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                MessageBox.Show("Service Started");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
              
            }
        }

        public static void StartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                MessageBox.Show("Service Started");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public static void StopService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                MessageBox.Show("Service Stopped");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public static void StopService(string serviceName, int timeoutMilliseconds, string machineName)
        {
            ServiceController service = new ServiceController(serviceName, machineName);
            try
            {
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);
                MessageBox.Show("Service Stopped");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        public static void RestartService(string serviceName, int timeoutMilliseconds)
        {
            ServiceController service = new ServiceController(serviceName);
            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                // count the rest of the timeout
                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                MessageBox.Show("Service ReStarted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
        public static void RestartService(string serviceName, int timeoutMilliseconds, string machineName)
        {
            ServiceController service = new ServiceController(serviceName, machineName);
            try
            {
                int millisec1 = Environment.TickCount;
                TimeSpan timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds);

                service.Stop();
                service.WaitForStatus(ServiceControllerStatus.Stopped, timeout);

                // count the rest of the timeout
                int millisec2 = Environment.TickCount;
                timeout = TimeSpan.FromMilliseconds(timeoutMilliseconds - (millisec2 - millisec1));

                service.Start();
                service.WaitForStatus(ServiceControllerStatus.Running, timeout);
                MessageBox.Show("Service ReStarted");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if (lBox.SelectedItem != null)
            {
                ServiceController sc = (ServiceController)lBox.SelectedItem;

                StopService(sc.ServiceName, 100000);
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            if (lBox.SelectedItem != null)
            {
                ServiceController sc = (ServiceController)lBox.SelectedItem;
                RestartService(sc.ServiceName, 100000);
            }
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {

            la.Content=SysUtil.StringEncodingConvert(@"\\test-server\SPCS Administration\Företag\Grillby AB", "UTF-8", "ANSI");

        }


    }



  
        public class SysUtil
        {
            /// <summary>
            /// Convert a string from one charset to another charset
            /// </summary>
            /// <param name="strText">source string</param>
            /// <param name="strSrcEncoding">original encoding name</param>
            /// <param name="strDestEncoding">dest encoding name</param>
            /// <returns></returns>
            public static String StringEncodingConvert(String strText, String strSrcEncoding, String strDestEncoding)
            {
                System.Text.Encoding srcEnc = System.Text.Encoding.GetEncoding(strSrcEncoding);
                System.Text.Encoding destEnc = System.Text.Encoding.GetEncoding(strDestEncoding);
                byte[] bData=srcEnc.GetBytes(strText);
                byte[] bResult = System.Text.Encoding.Convert(srcEnc, destEnc, bData);
                return destEnc.GetString(bResult);
            }

        }
    
}
