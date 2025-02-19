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
            ProcessStartInfo procInfo = new ProcessStartInfo();

            //исполняемый файл программы - браузер
            procInfo.FileName = @"C:\Users\dex\AppData\Local\Yandex\YandexBrowser\Application\browser.exe";

            // аргументы запуска - адрес интернет-ресурса
            procInfo.Arguments = "https://metanit.com";
            Process.Start(procInfo);

        }
    }
}
