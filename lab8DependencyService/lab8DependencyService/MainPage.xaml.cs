using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace lab8DependencyService
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            baterryclick.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new BatteryDemo());
            };

            qrclick.Clicked += async (sender, e) =>
            {
                await Navigation.PushAsync(new ScanDemo());
            };
        }
    }
}
