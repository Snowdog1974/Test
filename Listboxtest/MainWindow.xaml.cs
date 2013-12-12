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
using A_net;

namespace Listboxtest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public OfferMtrlList of = new OfferMtrlList();
        public MainWindow()
        {
            InitializeComponent();
            
            listBox1.ItemsSource = of;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            OfferMtrl item = new OfferMtrl();
            of.Add(item);
        }
    }
}
