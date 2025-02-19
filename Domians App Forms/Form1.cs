using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Domians_App_Forms
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AppDomain domain = AppDomain.CreateDomain("Domain test");

            // Запуск тестовых приложенй в контексте вторичных доменов
            domain.ExecuteAssembly(@"C:\DEX\Academy_TOP\System_Programming\Domians App Forms\bin\Debug\Domians App Forms.exe");
        }
    }
}
