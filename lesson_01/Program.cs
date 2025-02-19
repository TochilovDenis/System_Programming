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
            var process = Process.GetCurrentProcess();

            Console.WriteLine($"id : {process.Id}");
            Console.WriteLine($"process name: {process.ProcessName}");
            Console.WriteLine($"используемая память: {process.VirtualMemorySize64}");

        }
    }
}
