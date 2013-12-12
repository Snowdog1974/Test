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
using System.Data.SqlClient;
using System.IO;
using Microsoft.Win32.SafeHandles;
using System.Data;
using System.Runtime.InteropServices;
using System.Drawing;
using System.ComponentModel;
using System.Diagnostics;
using System.Globalization;
using SystemAndersson.Anet.BI.DocumentStore;
using SystemAndersson.Anet.BI.LoginSQL;
using System.Windows.Markup;
using System.Windows.Xps.Packaging;



namespace Filestreamtest
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window, INotifyPropertyChanged
    {

        DataSet ds;

        SqlConnection conn = new SqlConnection();
        public string ImgSource
        {
            get { return imgSource; }
            set 
            { 
                imgSource = value;
                OnPropertyChanged(new PropertyChangedEventArgs("ImgSource"));
            }
        }

        private string imgSource;

        private Bitmap img;
        public Bitmap Img
        {
            get { return img; }
            set
            {
                img = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Img"));
            }
        }


        private List<Documents> docList;
        public List<Documents> DocList
        {
            get { return docList; }
            set
            {
                docList = value;
                OnPropertyChanged(new PropertyChangedEventArgs("DocList"));
            }
        }
       

        public Window1()
        {
            InitializeComponent();
            
            DataContext = "{Binding RelativeSource={RelativeSource Self}}";
            Servers srv= new Servers();
           // conn =srv.CreateConnection(@"ankal-win7x64\sqlexpress", "AnetCompany01");
            //conn = new SqlConnection(
            //    @"Integrated Security=true;server=utv-server\sqlexpress;Initial Catalog=AnetCompany01");
            conn=srv.CreateConnectionIntegrated(@"utv-server\sqlexpress", "AnetCompany01");
            conn.Close();
            docList= DocumentReg.GetDocuments(conn,13,"AC42");
            dataGrid1.ItemsSource = DocList;
            string[] files = Directory.GetFiles(@"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\Converted");
             foreach (string file in files)
                 File.Delete(file);
            
             
            
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();


            // Display OpenFileDialog by calling ShowDialog method

            Nullable<bool> result = dlg.ShowDialog();



            // Get the selected file name and display in a TextBox

            if (result == true)
            {

                if (dlg.FileName.Length > 0)
                {

                    
                    DocumentReg.SaveDocument(conn, dlg.FileName, new Documents(0,2,"AC42","",null,5, new Guid(),"",DateTime.Now, DateTime.Now));
                   
                    //FilestreamControl.Put(dlg.FileName);
                    docList = DocumentReg.GetDocuments(conn, 2, "AC42");
                    dataGrid1.ItemsSource = DocList;

                    MessageBox.Show("Funktionen lyckades!");
                }

            }

            

            
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {



            string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\tempfil";
            DocumentReg.GetDocument(conn, test, "7359fbc0-273a-400d-bd5a-f64dbea7ecf5");
            test = test + ".doc";
            //Process.Start(test);
            //DocumentViewer viewer = new DocumentViewer();
            XpsDocument doc = new XpsDocument(test, FileAccess.Read);
            dv1.Document = doc.GetFixedDocumentSequence();
 
            
            //IDocumentPaginatorSource doc = (IDocumentPaginatorSource)
            //XamlReader.Load(test);
 
            
            //dv1.Document = test;

            //string test = @"C:\ProgramData\SystemAndersson\Temp\tempfil";
            //FilestreamControl.Get(test, "77150733-5899-4332-a6f0-ec61f4a73dab");
            //test = test + ".wmv";
            //Process.Start(test);
            //ImgSource = @"c:\1\bil.jpg";

           
        }

        

        private void Window_Closing(object sender, CancelEventArgs e)
        {
            string[] files = Directory.GetFiles(@"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp");
            foreach (string file in files)
                File.Delete(file);
 
        }

        private void button3_Click(object sender, RoutedEventArgs e)
        {
            FilestreamControl.Delete("af00dc37-2dfa-4979-8cc6-401c33fea0fd", 2, 2, "AC01");
            MessageBox.Show("Delete Compleate");
        }

              
       

        private void button6_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension

            dlg.DefaultExt = ".docx";

            dlg.Filter = "Word documents (*.doc;*.docx)|*.doc;*.docx|Excel documents (*.xls;*.xlsx)|*.xls;*.xlsx";

            

            // Display OpenFileDialog by calling ShowDialog method

            Nullable<bool> result = dlg.ShowDialog();



            // Get the selected file name and display in a TextBox

            if (result == true)
            {

                if (dlg.FileName.Length > 0)
                {

                    SelectedFileTextBox.Text = dlg.FileName;

                    string newXPSDocumentName = String.Concat(System.IO.Path.GetDirectoryName(dlg.FileName), "\\",

                                   System.IO.Path.GetFileNameWithoutExtension(dlg.FileName), ".xps");



                    // Set DocumentViewer.Document to XPS document
                  
                    FilestreamControl fc = new FilestreamControl();
                    string type = System.IO.Path.GetExtension(dlg.FileName);

                    if (type == ".doc" || type == ".docx")
                    {
                        dv1.Document = fc.ConvertWordDocToXPSDoc(dlg.FileName, newXPSDocumentName).GetFixedDocumentSequence();
                    }
                    else if (type == ".xls" || type == ".xlsx")
                    {
                        dv1.Document = fc.ConvertExcelDocToXPSDoc(dlg.FileName, newXPSDocumentName).GetFixedDocumentSequence();
                    }

                }

            }

        }

        private void button7_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension

            dlg.DefaultExt = ".jpg";

            dlg.Filter = "Image files (*.jpg;*.bmp;*.png;*.gif;)|*.jpg;*.bmp;*.png;*.gif|Media files (.wmv)|*.wmv|All files(.*)|*.*";

           

            // Display OpenFileDialog by calling ShowDialog method

            Nullable<bool> result = dlg.ShowDialog();



            // Get the selected file name and display in a TextBox

            if (result == true)
            {

                if (dlg.FileName.Length > 0)
                {

                    SelectedFileTextBoxMedia.Text = dlg.FileName;

                     System.Uri t = new System.Uri(dlg.FileName);
                    mediaElement1.Source = t;
                    

                   

                }

            }
        }

        private void button9_Click(object sender, RoutedEventArgs e)
        {
            string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\tempfil";

            FilestreamControl.Get(test, "050b10f5-0b97-4451-a80e-687f1d9d7a2f");
            test = test + ".jpg";
            SelectedFileTextBoxMedia.Text = test;
            System.Uri t = new System.Uri(test);
            mediaElement1.Source = t;


        }

        private void button8_Click(object sender, RoutedEventArgs e)
        {
            
            string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\tempfildoc";
            
            FilestreamControl.Get(test, "7359fbc0-273a-400d-bd5a-f64dbea7ecf5");
            test = test + ".doc";
            SelectedFileTextBox.Text = test;
            FilestreamControl fc = new FilestreamControl();
            XpsDocument xps = fc.ConvertWordDocToXPSDoc(test, @"c:\1\Andersson Terminal2.xps");
            dv1.Document = xps.GetFixedDocumentSequence();
          
        }

        private void button10_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension

            dlg.DefaultExt = ".docx";

            dlg.Filter = "Word documents (*.doc;*.docx)|*.doc;*.docx";



            // Display OpenFileDialog by calling ShowDialog method

            Nullable<bool> result = dlg.ShowDialog();



            // Get the selected file name and display in a TextBox

            if (result == true)
            {

                if (dlg.FileName.Length > 0)
                {

                    SelectedFileTextBox.Text = dlg.FileName;

                  


                   
                    Process.Start(dlg.FileName);

                }

            }

        }

        private void button12_Click(object sender, RoutedEventArgs e)
        {
            string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\tempfildoc";

            FilestreamControl.Get(test, "7359fbc0-273a-400d-bd5a-f64dbea7ecf5");
            test = test + ".doc";
            SelectedFileTextBox.Text = test;
            Process.Start(test);
        }

        private void button13_Click(object sender, RoutedEventArgs e)
        {
            string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\tempfil";

            FilestreamControl.Get(test, "77150733-5899-4332-a6f0-ec61f4a73dab");
            test = test + ".wmv";
            SelectedFileTextBoxMedia.Text = test;
            System.Uri t = new System.Uri(test);
            mediaElement1.Source = t;
        }

        private void button11_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension

            dlg.DefaultExt = ".pdf";

            dlg.Filter = "pdf documents (.pdf)|*.pdf";



            // Display OpenFileDialog by calling ShowDialog method

            Nullable<bool> result = dlg.ShowDialog();



            // Get the selected file name and display in a TextBox

            if (result == true)
            {

                if (dlg.FileName.Length > 0)
                {

                    SelectedFileTextBoxPdf.Text = dlg.FileName;

                    System.Diagnostics.Process process = new System.Diagnostics.Process(); process.StartInfo.FileName = dlg.FileName;
                    process.Start(); process.WaitForExit(); 

                }

            }

            
        }

      

        private void button15_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension

            dlg.DefaultExt = ".pdf";

            dlg.Filter = "pdf documents (.pdf)|*.pdf";



            // Display OpenFileDialog by calling ShowDialog method

            Nullable<bool> result = dlg.ShowDialog();



            // Get the selected file name and display in a TextBox

            if (result == true)
            {

                if (dlg.FileName.Length > 0)
                {

                    SelectedFileTextBoxPdf.Text = dlg.FileName;

                    var uc = new ucpdf(dlg.FileName);
                    this.windowsFormsHost1.Child = uc;

                }

            }

        }

        private void button16_Click(object sender, RoutedEventArgs e)
        {
            string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\tempfildoc";

            FilestreamControl.Get(test, "c0dae236-5098-48c0-abc4-1a2d2674a66f");
            test = test + ".pdf";
            SelectedFileTextBoxPdf.Text = test;
            var uc = new ucpdf(test);
            this.windowsFormsHost1.Child = uc;
        }

        private void button18_Click(object sender, RoutedEventArgs e)
        {
            string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\tempfildoc";

            FilestreamControl.Get(test, "564e8b67-8641-40dc-92b1-76716ddfb754");
            test = test + ".pdf";
            SelectedFileTextBoxPdf.Text = test;
            System.Diagnostics.Process process = new System.Diagnostics.Process(); process.StartInfo.FileName = test;
            process.Start(); process.WaitForExit(); 
           

           
        }

        private void button17_Click(object sender, RoutedEventArgs e)
        {
            // Create OpenFileDialog

            Microsoft.Win32.OpenFileDialog dlg = new Microsoft.Win32.OpenFileDialog();



            // Set filter for file extension and default file extension

            dlg.DefaultExt = ".xlsx";

            dlg.Filter = "Excel documents (*.xls;*.xlsx)|*.xls;*.xlsx";



            // Display OpenFileDialog by calling ShowDialog method

            Nullable<bool> result = dlg.ShowDialog();



            // Get the selected file name and display in a TextBox

            if (result == true)
            {

                if (dlg.FileName.Length > 0)
                {

                    SelectedFileTextBox.Text = dlg.FileName;





                    Process.Start(dlg.FileName);

                }

            }
        }

        private void button14_Click(object sender, RoutedEventArgs e)
        {

            string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\tempfilxls";

            FilestreamControl.Get(test, "d38fd386-6c10-4b47-832b-d38ca511ae7c");
            test = test + ".xls";
            SelectedFileTextBox.Text = test;
            FilestreamControl fc = new FilestreamControl();
            XpsDocument xps = fc.ConvertExcelDocToXPSDoc(test, @"c:\1\rapport4.xps");
            dv1.Document = xps.GetFixedDocumentSequence();

            //string xps = fc.ConvertExcelDocToPdfDoc(test, @"c:\1\rapport4.pdf");
            //var uc = new ucpdf(xps);
            //this.windowsFormsHost1.Child = uc;
        }

        private void button19_Click(object sender, RoutedEventArgs e)
        {
            string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\tempfildoc";

            DocumentReg.GetDocument(conn,test, "8b7a2222-49c4-41bd-97c5-fd1148eaca10");
            test = test + ".xls";
            SelectedFileTextBox.Text = test;
            Process.Start(test);
        }

        private void button5_Click(object sender, RoutedEventArgs e)
        {
            Documents doc = (Documents)dataGrid1.SelectedItem;
            if (doc.Extension==".pdf")
            {
                string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\" + doc.Description;
                FilestreamControl.Get(test, Convert.ToString(doc.DocumentGuid));
                test = test +doc.Extension;
                SelectedFileTextBoxPdf.Text = test;
                tabItem3.Focus();
                var uc = new ucpdf(test);
                this.windowsFormsHost1.Child = uc;

            }

            else if (doc.Extension == ".doc" || doc.Extension == ".docx")
            {
                string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\" + doc.Description;
                FilestreamControl.Get(test, Convert.ToString(doc.DocumentGuid));
                test = test + doc.Extension;
                SelectedFileTextBox.Text = test;
                tabItem1.Focus();
                FilestreamControl fc = new FilestreamControl();
                XpsDocument xps = fc.ConvertWordDocToXPSDoc(test, @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\" + doc.Description + ".xps");
                dv1.Document = xps.GetFixedDocumentSequence();

            }

            else if (doc.Extension == ".xls" || doc.Extension == ".xlsx")
            {
                string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\" + doc.Description;
                FilestreamControl.Get(test, Convert.ToString(doc.DocumentGuid));
                test = test + doc.Extension;
                SelectedFileTextBox.Text = test;
                tabItem1.Focus();
                FilestreamControl fc = new FilestreamControl();
                XpsDocument xps = fc.ConvertExcelDocToXPSDoc(test, @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\" + doc.Description + ".xps");
                dv1.Document = xps.GetFixedDocumentSequence();

            }

            else if (doc.Extension == ".jpg" || doc.Extension == ".bmp" || doc.Extension == ".png" || doc.Extension == ".gif" || doc.Extension==".wmv")
            {
                string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\" + doc.Description;
                FilestreamControl.Get(test, Convert.ToString(doc.DocumentGuid));
                test = test + doc.Extension;
                SelectedFileTextBoxMedia.Text = test;
                tabItem2.Focus();
                System.Uri t = new System.Uri(test);
                mediaElement1.Source = t;

            }




           
            
           

        }

        private void tabControl1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
         

        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Documents doc = (Documents)dataGrid1.SelectedItem;
            if (doc.Extension == ".pdf")
            {
                this.windowsFormsHost1.Child = null;
                tabItem3.Focus();
                string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\" + doc.Description;
                FilestreamControl.Get(test, Convert.ToString(doc.DocumentGuid));
                test = test + doc.Extension;
                SelectedFileTextBoxPdf.Text = test;
                var uc = new ucpdf(test);
                this.windowsFormsHost1.Child = uc;

                //this.windowsFormsHost1.Child = null;
                //tabItem3.Focus();
                //string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\" + doc.Description;
                //FilestreamControl.Get(test,Convert.ToString(doc.DocumentGuid));
                //test = test + doc.Extension;
                //SelectedFileTextBoxPdf.Text = test;
                //ProcessStartInfo psi = new ProcessStartInfo(test);
                //Process.Start(psi);


              
                

              

            }

            else if (doc.Extension == ".doc" || doc.Extension == ".docx")
            {
                dv1.Document = null;
                tabItem1.Focus();
                string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\" + doc.Description;
                FilestreamControl.Get(test, Convert.ToString(doc.DocumentGuid));
                test = test + doc.Extension;
                SelectedFileTextBox.Text = test;
                FilestreamControl fc = new FilestreamControl();
                XpsDocument xps = fc.ConvertWordDocToXPSDoc(test, @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\Converted\" + doc.Description + ".xps");
                dv1.Document = xps.GetFixedDocumentSequence();

            }

            else if (doc.Extension == ".xls" || doc.Extension == ".xlsx")
            {
                dv1.Document = null;
                tabItem1.Focus();
                string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\" + doc.Description;
                FilestreamControl.Get(test, Convert.ToString(doc.DocumentGuid));
                test = test + doc.Extension;
                SelectedFileTextBox.Text = test;
                FilestreamControl fc = new FilestreamControl();
                XpsDocument xps = fc.ConvertExcelDocToXPSDoc(test, @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\Converted\" + doc.Description + ".xps");
                dv1.Document = xps.GetFixedDocumentSequence();

            }

            else if (doc.Extension == ".jpg" || doc.Extension == ".bmp" || doc.Extension == ".png" || doc.Extension == ".gif" || doc.Extension == ".wmv")
            {
                mediaElement1.Source = null;
                tabItem2.Focus();
                string test = @"C:\ProgramData\SystemAndersson\AnderssonProduktion\Temp\" + doc.Description;
                FilestreamControl.Get(test, Convert.ToString(doc.DocumentGuid));
                test = test + doc.Extension;
                SelectedFileTextBoxMedia.Text = test;
                System.Uri t = new System.Uri(test);
                mediaElement1.Source = t;
                if (doc.Extension == ".wmv")
                {
                    button22.Visibility = Visibility.Visible;
                    button21.Visibility = Visibility.Visible;
                    button20.Visibility = Visibility.Visible;
                    progressBar1.Visibility = Visibility.Visible;
                    label1.Visibility = Visibility.Visible;
                    label1.Content = mediaElement1.Clock;
                }
                else if (doc.Extension != ".wmv")
                {
                    button22.Visibility = Visibility.Hidden;
                    button21.Visibility = Visibility.Hidden;
                    button20.Visibility = Visibility.Hidden;
                    progressBar1.Visibility = Visibility.Hidden;
                }

            }

            
        }

        
            

       

        private void button20_Click_1(object sender, RoutedEventArgs e)
        {
            mediaElement1.LoadedBehavior = System.Windows.Controls.MediaState.Stop;
             
        }

        private void button21_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.LoadedBehavior = System.Windows.Controls.MediaState.Play;
        }

        private void button22_Click(object sender, RoutedEventArgs e)
        {
            mediaElement1.LoadedBehavior = System.Windows.Controls.MediaState.Pause;
            
            MessageBox.Show(mediaElement1.Position.Seconds.ToString() + " | " + mediaElement1.NaturalDuration+ " | "+mediaElement1.Clock);
          //  mediaElement1.HasVideoCl
            
            
        }

       


        


    }

    public sealed class ImageConverter : IValueConverter
    {
        public object Convert(object value, Type targetType,
                              object parameter, CultureInfo culture)
        {
            try
            {
                return new BitmapImage(new Uri((string)value));
            }
            catch
            {
                return new BitmapImage();
            }
        }

        public object ConvertBack(object value, Type targetType,
                                  object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    } 
}
