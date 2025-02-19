using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Multithreading
{
    class Program
    {
        static void Main(string[] args)
        {
            void Print() => Console.WriteLine("Hello Threads");

            Thread myThread = new Thread(Print);

            for(int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Главный поток: {i}");
                Thread.Sleep(300);
            }

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine($"Второй поток: {i}");
                Thread.Sleep(300);
            }
        }
    }
}
