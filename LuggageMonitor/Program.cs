using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
namespace LuggageMonitor
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);

            if (System.Diagnostics.Process.GetProcessesByName(System.Diagnostics.Process.GetCurrentProcess().ProcessName).Length > 1)
            {
                MessageBox.Show("已经有一个相同的程序在运行");
            }
            else
            {
                try
                {
                    string startProgram = ConfigurationManager
                                     .AppSettings["StartProgramName"];
                    if (startProgram.Equals("Fore"))
                    {
                        FrmForceBootMonitor fb = new FrmForceBootMonitor();

                        Application.Run(fb);
                    }
                    else if (startProgram.Equals("Real"))
                    {
                        Application.Run(new FrmRealBootMonitor());
                    }
                    else
                    {
                        Application.Run(new frmMain());
                    }
                }
                catch (Exception ex) { 
                    throw ex; 
                }

            }

        }
    }
}
