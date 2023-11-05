using lab8DependencyService.Droid;
using System.Threading.Tasks;
using ZXing.Mobile;

[assembly: Xamarin.Forms.Dependency(typeof(QrScanningService))]

namespace lab8DependencyService.Droid
{
    internal class QrScanningService : IQrScanningService
    {
        async Task<string> IQrScanningService.ScanAsync()
        {
            var optionsDefault = new MobileBarcodeScanningOptions();
            var optionsCustom = new MobileBarcodeScanningOptions();

            var scanner = new MobileBarcodeScanner()
            {
                TopText = "Scan the QR Code",
                BottomText = "Please Wait",
            };

            var scanResult = await scanner.Scan(optionsCustom);
            return scanResult.Text;
        }
    }
}