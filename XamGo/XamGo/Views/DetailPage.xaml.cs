using System;
using System.Collections.Generic;

using Xamarin.Forms;
using XamGo.Models;

namespace XamGo.Views
{
    public partial class DetailPage : ContentPage
    {
        public List<GridImage> myImgs = new List<GridImage>();

        public int index = 0;

        public int size = 0;

        public DetailPage(List<GridImage> g, int i)
        {
            myImgs = g;
            index = i;
            size = myImgs.Count;
            InitializeComponent();
            UpdateImage();
        }

        public void UpdateImage()
        {
            imgDee.Source = myImgs[index].imgSrc;

        }

        public void OnSwipe(object sedner, EventArgs e)
        {
            string direction = ((SwipedEventArgs)e).Parameter.ToString();
            Console.WriteLine("direction: " + direction);
            // move index once in reverse-swipe direction
            if (direction.Equals("Right"))
            {
                index = (index == 0) ? (size -1) : (index -1);
            }
            else
            {
                index = (index + 1) % size;
            }
            Console.WriteLine("NEW index: " + index);

            UpdateImage();
        }
    }

    
}

