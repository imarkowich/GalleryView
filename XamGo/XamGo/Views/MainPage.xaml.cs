using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using XamGo.Helpers;

using XamGo.Models;
using XamGo.Views;
using Xamarin.Essentials;


namespace XamGo
{
    public partial class MainPage : ContentPage
    {
        public List<GridImage> myImgs = new List<GridImage>();

        public readonly string basePath = "XamGo.Resources.Pictures.";

        public readonly string thumbPath = "XamGo.Resources.Thumbnails.";


        public String CellWidth {get; set;}


        public MainPage()
        {
            //double number = Application.Current.MainPage.Width / 3.0;
            //CellWidth = number.ToString();

            //var displayInfo = DeviceDisplay.MainDisplayInfo;
            //var width = (displayInfo.Width / displayInfo.Density) / 3.0;
            //CellWidth = width.ToString();
            //CellWidth = "10";
            // iterate through folder, get all photos
            //ImageSource img = GetImage(basePath + "wild-giraffe.jpg");
            //GridImage myG = new GridImage(img, false);
            //myImgs.Add(myG);

            InitializeComponent();
            AddGridImages();
            collectBig.ItemsSource = myImgs;
        }



        //<Image Source="{local:ImageResource XamGo.Resources.Pictures.wild-giraffe.jpg}" Aspect="AspectFill"/>
        // convert embedded resource to imagesource
        public ImageSource GetImage(string imgPath)
        {
            var imageSource = ImageSource.FromResource(imgPath, typeof(MainPage).GetTypeInfo().Assembly);
            return imageSource;
        }

        // when any image is tapped, navigate to DetailPage
        public async void OnImgTapped(object sender, EventArgs e)
        {
            int index = (int) ((TappedEventArgs)e).Parameter;
            Console.WriteLine(index);
            Console.WriteLine(sender);
            //DisplayAlert("WOWZA!", "WOWZA WOWZA WOWZA", "WOWZA");
            await Navigation.PushAsync(new DetailPage(myImgs, index));
        }


        // add full images and thumbnails to Gridimages List
        public void AddGridImages()
        {
            myImgs.Add(new GridImage(GetImage(basePath + "wild-giraffe.jpg"), GetImage(thumbPath + "wild-giraffe.jpg"), 0, false));
            myImgs.Add(new GridImage(GetImage(basePath + "11 year olds tweents.jpg"), GetImage(thumbPath + "11 year olds tweents.jpg"), 1, false));
            myImgs.Add(new GridImage(GetImage(basePath + "20191229_120351.jpg"), GetImage(thumbPath + "20191229_120351.jpg"), 2, false));
            myImgs.Add(new GridImage(GetImage(basePath + "20200607_172218-2.jpg"), GetImage(thumbPath + "20200607_172218-2.jpg"), 3, false));
            myImgs.Add(new GridImage(GetImage(basePath + "20200808_195811.jpg"), GetImage(thumbPath + "20200808_195811.jpg"), 4, false));
            myImgs.Add(new GridImage(GetImage(basePath + "20200919_142340.jpg"), GetImage(thumbPath + "20200919_142340.jpg"), 5, false));
            myImgs.Add(new GridImage(GetImage(basePath + "Children-Standing-Desks.jpeg"), GetImage(thumbPath + "Children-Standing-Desks.jpeg"), 6, false));
            myImgs.Add(new GridImage(GetImage(basePath + "DSC_0765.jpg"), GetImage(thumbPath + "DSC_0765.jpg"), 7, false));
            myImgs.Add(new GridImage(GetImage(basePath + "good-faces-xmSWVeGEnJw-unsplash.jpg"), GetImage(thumbPath + "good-faces-xmSWVeGEnJw-unsplash.jpg"), 8, false));
            myImgs.Add(new GridImage(GetImage(basePath + "IMG_1218.jpg"), GetImage(thumbPath + "IMG_1218.jpg"), 9, false));
            myImgs.Add(new GridImage(GetImage(basePath + "IMG_7355_Original.jpg"), GetImage(thumbPath + "IMG_7355_Original.jpg"), 10, false));
            myImgs.Add(new GridImage(GetImage(basePath + "IMG_8298.jpg"), GetImage(thumbPath + "IMG_8298.jpg"), 11, false));
            myImgs.Add(new GridImage(GetImage(basePath + "nathan-dumlao-71u2fOofI-U-unsplash.jpg"), GetImage(thumbPath + "nathan-dumlao-71u2fOofI-U-unsplash.jpg"), 12, false));
            myImgs.Add(new GridImage(GetImage(basePath + "PlaylistCareerReadiness.png"), GetImage(thumbPath + "PlaylistCareerReadiness.png"), 13, false));
            myImgs.Add(new GridImage(GetImage(basePath + "school outside of Durban.jpg"), GetImage(thumbPath + "school outside of Durban.jpg"), 14, false));
            myImgs.Add(new GridImage(GetImage(basePath + "24-36in.jpg"), GetImage(thumbPath + "24-36in.jpg"), 15, false));
            myImgs.Add(new GridImage(GetImage(basePath + "gator1.jpeg"), GetImage(thumbPath + "gator1.jpeg"), 16, false));
            myImgs.Add(new GridImage(GetImage(basePath + "gator2.jpeg"), GetImage(thumbPath + "gator2.jpeg"), 17, false));
            myImgs.Add(new GridImage(GetImage(basePath + "gator3.jpeg"), GetImage(thumbPath + "gator3.jpeg"), 18, false));
            myImgs.Add(new GridImage(GetImage(basePath + "gator4.jpeg"), GetImage(thumbPath + "gator4.jpeg"), 19, false));
            myImgs.Add(new GridImage(GetImage(basePath + "gator5.jpeg"), GetImage(thumbPath + "gator5.jpeg"), 20, false));
            myImgs.Add(new GridImage(GetImage(basePath + "gator6.jpeg"), GetImage(thumbPath + "gator6.jpeg"), 21, false));
            myImgs.Add(new GridImage(GetImage(basePath + "gator7.jpeg"), GetImage(thumbPath + "gator7.jpeg"), 22, false));
            myImgs.Add(new GridImage(GetImage(basePath + "gator8.jpeg"), GetImage(thumbPath + "gator8.jpeg"), 23, false));
        }
    }
}

