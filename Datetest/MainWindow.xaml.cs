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
using System.Globalization;

namespace Datetest
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

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            
            DateTime dt = DateTime.Parse(datePicker1.Text);
           
            label2.Content=dt.DayOfWeek;


           
           // datePicker1.Language.IetfLanguageTag = CultureInfo.CurrentCulture;
            label3.Content = datePicker1.Language.ToString();
            
            label4.Content = datePicker1.FirstDayOfWeek.ToString();
            label1.Content = GetYearWeekNoDayNo(dt);
        }

        public string GetYearWeekNoDayNo(DateTime dt)
        {
            return dt.Year + "-" + GetWeekNumber(dt) + "-" + GetDayNoInWeek(dt);
        
        }


        public static int GetDayNoInWeek(DateTime dtPassed)
        {
            int day = 0;


            if (DayOfWeek.Monday == dtPassed.DayOfWeek)
            {
                day = 1;
            }
            else if (DayOfWeek.Tuesday == dtPassed.DayOfWeek)
            {
                day = 2;
            }
            else if (DayOfWeek.Wednesday == dtPassed.DayOfWeek)
            {
                day = 3;
            }
            else if (DayOfWeek.Thursday == dtPassed.DayOfWeek)
            {
                day = 4;
            }
            else if (DayOfWeek.Friday == dtPassed.DayOfWeek)
            {
                day = 5;
            }
            else if (DayOfWeek.Saturday == dtPassed.DayOfWeek)
            {
                day = 6;
            }
            else if (DayOfWeek.Sunday == dtPassed.DayOfWeek)
            {
                day = 7;
            }

            return day;
        }
    
        public static int GetWeekNumber(DateTime dtPassed)
        {


        CultureInfo ciCurr = CultureInfo.CurrentCulture;


        int weekNum = ciCurr.Calendar.GetWeekOfYear(dtPassed, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);


        return weekNum;


        }

        private void datePicker1_SelectedDateChanged(object sender, SelectionChangedEventArgs e)
        {

            DateTime dt = DateTime.Parse(datePicker1.Text);

            label2.Content = dt.DayOfWeek;



            // datePicker1.Language.IetfLanguageTag = CultureInfo.CurrentCulture;
            label3.Content = datePicker1.Language.ToString();

            label4.Content = datePicker1.FirstDayOfWeek.ToString();
            label1.Content = GetYearWeekNoDayNo(dt);
            textBox1.Text = (string)label1.Content;
        }

    }
}
