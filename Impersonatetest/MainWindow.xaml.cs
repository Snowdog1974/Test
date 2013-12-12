using Microsoft.Win32.SafeHandles;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Management;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Security;
using System.Security.Permissions;
using System.Security.Principal;
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
using SystemAndersson.Anet.BI.Utilities;

namespace Impersonatetest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        [DllImport("advapi32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        public static extern bool LogonUser(String lpszUsername, String lpszDomain, String lpszPassword,
            int dwLogonType, int dwLogonProvider, out SafeTokenHandle phToken);

        [DllImport("kernel32.dll", CharSet = CharSet.Auto)]
        public extern static bool CloseHandle(IntPtr handle);

        // Test harness. 
        // If you incorporate this code into a DLL, be sure to demand FullTrust.
        [PermissionSetAttribute(SecurityAction.Demand, Name = "FullTrust")]
        
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SafeTokenHandle safeTokenHandle;
            try
            {
                string userName, domainName;
                // Get the user token for the specified user, domain, and password using the 
                // unmanaged LogonUser method. 
                // The local machine name can be used for the domain name to impersonate a user on this machine.
                label1.Content="Enter the name of the domain on which to log on: ";
                domainName = tbox1.Text;

                label1.Content="Enter the login of a user on {0} that you wish to impersonate: " + domainName;
                userName = tbox1.Text;

                label1.Content="Enter the password for {0}: " + userName;

                const int LOGON32_PROVIDER_DEFAULT = 0;
                //This parameter causes LogonUser to create a primary token. 
                const int LOGON32_LOGON_INTERACTIVE = 2;

                // Call LogonUser to obtain a handle to an access token. 
                bool returnValue = LogonUser(userName, domainName, tbox1.Text,
                    LOGON32_LOGON_INTERACTIVE, LOGON32_PROVIDER_DEFAULT,
                    out safeTokenHandle);

                label1.Content="LogonUser called.";

                if (false == returnValue)
                {
                    int ret = Marshal.GetLastWin32Error();
                    Console.WriteLine("LogonUser failed with error code : {0}", ret);
                    throw new System.ComponentModel.Win32Exception(ret);
                }
                using (safeTokenHandle)
                {
                    label2.Content="Did LogonUser Succeed? " + (returnValue ? "Yes" : "No");
                    label3.Content = "Value of Windows NT token: " + safeTokenHandle;

                    // Check the identity.
                   label4.Content="Before impersonation: "
                        + WindowsIdentity.GetCurrent().Name;
                    // Use the token handle returned by LogonUser. 
                    using (WindowsIdentity newId = new WindowsIdentity(safeTokenHandle.DangerousGetHandle()))
                    {
                        using (WindowsImpersonationContext impersonatedUser = newId.Impersonate())
                        {

                            // Check the identity.
                            label5.Content="After impersonation: "
                                + WindowsIdentity.GetCurrent().Name;
                        }
                    }
                    // Releasing the context object stops the impersonation 
                    // Check the identity.
                    label2.Content="After closing the context: " + WindowsIdentity.GetCurrent().Name;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Exception occurred. " + ex.Message);
            }
        
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            t.ItemsSource = Directory.GetDirectories(@"\\SBS\Slask\");
        //    string r = GetWorkGroup();
        //    MessageBox.Show(r);
        }

        //public static string GetWorkGroup()
        //{
        //    ManagementObject computer_system = new ManagementObject(
        //    string.Format(
        //    "Win32_ComputerSystem.Name='{0}'",
        //    Environment.MachineName));
            
        //    object result = computer_system["Workgroup"];
        //    return result.ToString();
        //}


        //public static string GetDomain()
        //{
        //    ManagementObject computer_system = new ManagementObject(
        //    string.Format(
        //    "Win32_ComputerSystem.Name='{0}'",
        //    Environment.MachineName));

        //    object result = computer_system["domain"];
        //    return result.ToString();
        //}

        //public static bool CheckIfDomain()
        //{
        //    string d = GetDomain();
        //    if (d == null || d == "")
        //    {
        //        return false;
        //    }
        //    else
        //    {
        //        return true;
        //    }

          
        //}




        private void Button_Click_2(object sender, RoutedEventArgs e)
        {

            //if (Network.CheckIfDomain() == true)
            //{
            //    MessageBox.Show("datorn ingår i en domän");
            //}
            //else
            //{
            //    MessageBox.Show("datorn ingår inte i en domän");
            //}
            string result = Network.GetDomain();
            label1.Content = result;


            if (result == null || result == "")
            {
                label1.Content = Network.GetWorkGroup();

            }
        }


    }

    public sealed class SafeTokenHandle : SafeHandleZeroOrMinusOneIsInvalid
    {
        private SafeTokenHandle()
            : base(true)
        {
        }

        [DllImport("kernel32.dll")]
        [ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
        [SuppressUnmanagedCodeSecurity]
        [return: MarshalAs(UnmanagedType.Bool)]
        private static extern bool CloseHandle(IntPtr handle);

        protected override bool ReleaseHandle()
        {
            return CloseHandle(handle);
        }
    }

    
   

}
