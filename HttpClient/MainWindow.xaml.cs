using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.Http;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;
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

namespace HttpClientRest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

       private FaceBookUserWPF fbook;

        public MainWindow()
        {
            InitializeComponent();
            getInformationFromFaceBookStatus();
        }

       

        private async void getInformationFromFaceBook()
        {
            HttpClient _httpClient = new HttpClient();

            HttpResponseMessage message = await _httpClient.GetAsync("https://graph.facebook.com/snowdog74");

            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(FaceBookUser));
            var _faceBookUser = (FaceBookUser)dcjs.ReadObject(await message.Content.ReadAsStreamAsync());

            fbook= new FaceBookUserWPF(_faceBookUser.Id, _faceBookUser.UserName, _faceBookUser.Gender, _faceBookUser.Name, _faceBookUser.Link);
            
            MessageBox.Show("Id: " + _faceBookUser.Id + " Name: " + _faceBookUser.Name + " Gender: " + _faceBookUser.Gender + " UserName: " + _faceBookUser.UserName +  " Link: "+_faceBookUser.Link); 
        }

        private async void getInformationFromFaceBookStatus()
        {
            HttpClient _httpClient = new HttpClient();

            HttpResponseMessage message = await _httpClient.GetAsync("https://graph.facebook.com/snowdog74/4100701550539");

            DataContractJsonSerializer dcjs = new DataContractJsonSerializer(typeof(FaceBookStatus));
            var _faceBookStatus = (FaceBookStatus)dcjs.ReadObject(await message.Content.ReadAsStreamAsync());



            MessageBox.Show("Id: " + _faceBookStatus.Id + " Message: " + _faceBookStatus.Message);
        }


        public FaceBookUserWPF FBook
        {

            get { return fbook; }
            set
            {
                fbook = value;
                OnPropertyChanged(new PropertyChangedEventArgs("FBook"));
            }

        }
        
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }
    }

    


    [DataContract]
    public class FaceBookUser
    {
        [DataMember(Name = "name")]
        public string Name;
        [DataMember(Name = "id")]
        public string Id;
        [DataMember(Name = "gender")]
        public string Gender;
        [DataMember(Name = "username")]
        public string UserName;
        [DataMember(Name = "link")]
        public string Link;
    }

    [DataContract]
    public class FaceBookStatus
    {
        //[DataMember(Name = "name")]
        //public string Name;
        [DataMember(Name = "id")]
        public string Id;
        [DataMember(Name = "message")]
        public string Message;
        //[DataMember(Name = "username")]
        //public string UserName;
       
    }

    [DataContract]
    public class FaceBookPicture
    {
        [DataMember(Name = "picture")]
        public Image Picture;
       
    }



    public class FaceBookUserWPF : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get { return name; }
            set
            {
                name = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Name"));
            } 
        }

        private string id;
        public string Id
        {
            get { return id; }
            set
            {
                id = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Id"));
            }
        }

        private string gender;
        public string Gender
         {
            get { return gender; }
            set
            {
                gender = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Gender"));
            } 
        }
        private string userName;
        public string UserName
        {
            get { return userName; }
            set
            {
                userName = value;
                OnPropertyChanged(new PropertyChangedEventArgs("UserName"));
            }
        }

        private string link;
        public string Link
        {
            get { return link; }
            set
            {
                link = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Link"));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, e);
        }

        public FaceBookUserWPF()
        {

        }

        public FaceBookUserWPF(string id, string userName, string gender, string name, string link)
        {
            Id = id;
            UserName = userName;
            Gender = gender;
            Name = name;
            Link = link;
        }
    }

}


