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
using SystemAndersson.Anet.BI.Production;
using System.Data.SqlClient;
using System.Reflection;
using SystemAndersson.Anet.BI.Reservations;
using SystemAndersson.Anet.BI.Article;

namespace Prodtest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int caretindex = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            SqlConnection con= new SqlConnection();
           
             string Datasource = @"Data Source=UTV-Server\SQLEXPRESS;";
            string Company = "Initial Catalog=AnetCompany02;";
            con.ConnectionString = Datasource + Company + "User Id=Andersson; Password=andersson;";
           // ProductionOrderItem p= ProductionOrderReg.GetProductionOrder(con, "1001");

            ProductionOrderItem poi = new ProductionOrderItem(0, "1000", "", "", "", "", DateTime.Today, DateTime.Today,
          "", DateTime.Today, DateTime.Today, DateTime.Today, 0, 0, "", "", "", 0, "", "",
          0, 0, 0, "", "", false, false, false, false, "U", 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, null, 1, "", "AK", "", DateTime.Today, DateTime.Today);
            ProductionOrderReg pr = new ProductionOrderReg();
            //pr.SaveProductionOrder(con, poi, Guid.Empty);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
             SqlConnection con= new SqlConnection();
           
             string Datasource = @"Data Source=UTV-Server\SQLEXPRESS;";
            string Company = "Initial Catalog=AnetCompany02;";
            con.ConnectionString = Datasource + Company + "User Id=Andersson; Password=andersson;";  
            Article art = new Article();

            
            
            

           


            //art.ArticleNo = "1003";
            //art.ArticleId = 5;
            //tbox.Text=ArticleReservationReg.GetBookedMaterial(con, art, "U").ToString();
            //dgrid.ItemsSource = ArticleReservationReg.GetBookedMaterialDetails(con, art, "U");

            art.ArticleNo = "K100";
            art.ArticleId = 2;
            tbox.Text = ArticleReservationReg.GetBookedMaterialOffer(con, art, "A").ToString();
            dgrid.ItemsSource = ArticleReservationReg.GetBookedMaterialOfferDetails(con, art, "A");


            //art.ArticleNo = "Egen 100";
            //art.ArticleId = 39;
            //tbox.Text = ArticleReservationReg.GetIncomingFromProdOrder(con, art, "A").ToString();
            //dgrid.ItemsSource = ArticleReservationReg.GetIncomingFromProdOrderDetails(con, art, "A");


            //art.ArticleNo = "1000";
            //art.ArticleId = 2;
            //tbox.Text=ArticleReservationReg.GetPurchasedMaterial(con, art, "I").ToString();
            //dgrid.ItemsSource=ArticleReservationReg.GetPurchasedMaterialDetails(con, art, "I");
        }

        //private void SetSelection(PasswordBox passwordBox, int start, int length) { passwordBox.GetType().GetMethod("Insert", BindingFlags.Instance | BindingFlags.NonPublic).Invoke(passwordBox, new object[] { start, length }); }

        ////After that, call it like this to set the cursor position: // set the cursor position to 2... or lenght of the password SetSelection( passwordBox1, 2, 0); 

        //// focus the control to update the selection passwordBox1.Focus(); 


        //private void button2_Click(object sender, RoutedEventArgs e)
        //{
        //    SetSelection(passwordBox1, caretindex, 5);
        //    caretindex = caretindex + 1;
        //    passwordBox1.Focus();
        //}
    }
}
