using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace lab8DependencyService
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ScanDemo : ContentPage
    {
        public ScanDemo()
        {
            InitializeComponent();
        }
        private async void BtnScan_Clicked(object sender, EventArgs e)
        {
            try
            {
                var scanner = DependencyService.Get<IQrScanningService>();
                var result = await scanner.ScanAsync();
                if (result != null)
                {
                    txtBarcode.Text = result;
                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}