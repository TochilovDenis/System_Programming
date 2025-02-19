using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Domains
{
    class Program
    {
        static void Main(string[] args)
        {
            AppDomain domain = AppDomain.CreateDomain("Domain test");

            // Запуск тестовых приложенй в контексте вторичных доменов
            domain.ExecuteAssembly(@"C:\DEX\Academy_TOP\System_Programming\Domains\bin\Debug\Domains.exe");
        }
    }
}
