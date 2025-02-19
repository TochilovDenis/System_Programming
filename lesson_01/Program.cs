using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace lesson_01
{
    class Program
    {
        static void Main(string[] args)
        {
            Process prc = Process.Start(@"C:\Users\dex\AppData\Local\Yandex\YandexBrowser\Application\browser.exe");
        }
    }
}
