using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerentWindow
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {


            //const string PATH = @"C:\Users\barak\Documents\visual studio 2013\Projects\PerentWindow\ChidWindow\bin\Debug\ChildWindow.exe";
            var startInfo = new ProcessStartInfo(@"C:\Program Files\Java\jre1.8.0_31\bin\javaw.exe")
            {
                UseShellExecute = false,
                RedirectStandardInput = true,
                RedirectStandardOutput = true,
                //CreateNoWindow = true,
                Arguments = " -jar SimpleStdWriter.jar"

            };

            var child = Process.Start(startInfo);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1(child));
        }
    }
}
