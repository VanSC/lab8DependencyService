using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace lab8DependencyService
{
    public interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
