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
            Process[] vsProcs = Process.GetProcessesByName("browser");
            foreach(var process in vsProcs)
            {
                Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
            }

        }
    }
}
