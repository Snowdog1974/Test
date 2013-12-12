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

namespace Interface
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
            //itest abc = new test();
            //label1.Content=abc.print();
            //itest abcd = new test2();
            //label2.Content = abcd.print();


            itest[] refabc = { new test(), new test2(), new test3() };
            for (int i = 0; i <= 2; i++)
            {
             listBox1.Items.Add(refabc[i].print());
            }

        }
    }
}
