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
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName}");
                ProcessThreadCollection processThreads = process.Threads;

                foreach(ProcessThread prcth in processThreads)
                {
                    Console.WriteLine($"ID: {prcth.Id}");
                }
            }

        }
    }
}
