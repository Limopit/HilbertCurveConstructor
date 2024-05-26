using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Threading.Tasks;
using System.Windows.Forms;
using HilbertCurveConstructor.Forms;

namespace HilbertCurveConstructor
{
    static class Program
    {
        public static ApplicationContext context { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            context = new ApplicationContext(new SplashForm());
            Application.Run(context);
        }
    }
}