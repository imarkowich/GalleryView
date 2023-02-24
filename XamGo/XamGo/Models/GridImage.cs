using System;
using Xamarin.Forms;

namespace XamGo.Models
{
    public class GridImage
    {
        public ImageSource imgSrc { get; set; }

        public ImageSource thumbnail { get; set; }

        public int ID { get; set; }

        public bool favorite { get; set; }

        public GridImage(ImageSource imgSrc, ImageSource thumbnail, int ID, bool favorite)
        {
            this.imgSrc = imgSrc;
            this.thumbnail = thumbnail;
            this.ID = ID;
            this.favorite = favorite;
        }
    }
}

