using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace App12
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public string Title="sss";
        public MainPage()
        {
            Title = "hello";
            this.InitializeComponent();
            //MapControl1.MapServiceToken = "vd34vicGpxh7TwgxQfSU~zvvRdIKnGfMKwvVpoFlV5A~AvwZp9OR2H6w4prku3KLMbSRCEGnH8kKCaQIiujr6rIivEmSefsZwV8dVdKcOzXp";

        }

        //private async void Button_Click(object sender, RoutedEventArgs e)
        //{
        //    // Set your current location.
        //    var accessStatus = await Geolocator.RequestAccessAsync();
        //    switch (accessStatus)
        //    {
        //        case GeolocationAccessStatus.Allowed:

        //            // Get the current location.
        //            Geolocator geolocator = new Geolocator();
        //            Geoposition pos = await geolocator.GetGeopositionAsync();
        //            Geopoint myLocation = pos.Coordinate.Point;

        //            // Set the map location.
        //            MapControl1.Center = myLocation;
        //            MapControl1.ZoomLevel = 12;
        //            MapControl1.LandmarksVisible = true;
        //            break;

        //        case GeolocationAccessStatus.Denied:
        //            // Handle the case  if access to location is denied.
        //            break;

        //        case GeolocationAccessStatus.Unspecified:
        //            // Handle the case if  an unspecified error occurs.
        //            break;
        //    }
        //}
    }
}
