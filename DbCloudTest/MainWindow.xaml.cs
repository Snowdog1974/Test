using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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

namespace DbCloudTest
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
         SqlConnection AConn= new SqlConnection();
         AConn.ConnectionString="Server=tcp:gakqabsgv9.database.windows.net,1433;Database=ankal;User ID=andersson@gakqabsgv9;Password=!System2013;Trusted_Connection=False;Encrypt=True;Connection Timeout=30";
         MessageBox.Show("Lyckades");
         AConn.Open();
           
         MessageBox.Show("Open Lyckades");
         AConn.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            using (new WaitCursor())
            {
                System.Threading.Thread.Sleep(5000);
            }
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            using (OverrideCursor cursor = new OverrideCursor(Cursors.Wait))
            {
                System.Threading.Thread.Sleep(5000);
            }
        }
    }
    public class WaitCursor : IDisposable
    {
        private Cursor _previousCursor;

        public WaitCursor()
        {
            _previousCursor = Mouse.OverrideCursor;

            Mouse.OverrideCursor = Cursors.Wait;
        }

        #region IDisposable Members

        public void Dispose()
        {
            Mouse.OverrideCursor = _previousCursor;
        }

        #endregion
    }

     public class OverrideCursor : IDisposable
    {
         static Stack<Cursor> s_Stack = new Stack<Cursor>();

    public OverrideCursor(Cursor changeToCursor)
  {
    s_Stack.Push(changeToCursor);

    if (Mouse.OverrideCursor != changeToCursor)
      Mouse.OverrideCursor = changeToCursor;
  }

  public void Dispose()
  {
    s_Stack.Pop();

    Cursor cursor = s_Stack.Count > 0 ? s_Stack.Peek() : null;

    if (cursor != Mouse.OverrideCursor)
      Mouse.OverrideCursor = cursor;
  }

        
    }
   

}


