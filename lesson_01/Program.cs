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
            Process[] vsProcs = Process.GetProcessesByName("devenv");
            foreach(var process in vsProcs)
            {
                Console.WriteLine("--------------------------------");
                Console.WriteLine($"ID: {process.Id}  Name: {process.ProcessName} StartTime: {process.StartTime}");
                
                ProcessModuleCollection prcModul = process.Modules;
                foreach (ProcessModule module in prcModul)
                {
                    Console.WriteLine($"Name: {module.ModuleName} FileName: {module.FileName} Version: {module.FileVersionInfo}");
                }
            }

        }
    }
}
