using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Foundation.Metadata;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWPClient
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            //DisplayImage("ms-appx:///flash.gif", false);
        }

        public void DisplayImage(string uri, bool canAutoPlay)
        {
            var bitmap = new BitmapImage(new Uri(uri));

            if (ApiInformation.IsApiContractPresent("Windows.Foundation.UniversalApiContract", 3)) bitmap.AutoPlay = canAutoPlay;

            var image = new Image();
            image.Source = bitmap;
            this.Content = image;
        }
    }
}
