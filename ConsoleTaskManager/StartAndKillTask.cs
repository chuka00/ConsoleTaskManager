using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleTaskManager
{
    public class StartAndKillTask
    {
        public static void StartACustomProcess()
        {
            Process theProc = null;
            try
            {
                Console.WriteLine("kindly input or paste path to exe file or url");
                string filePath = Console.ReadLine();
                Console.WriteLine("Enter file or url name");
                string enterFile = Console.ReadLine();

                string signs = @"^(([^\s]|(\\ ))*)(?<!\\).*$";
                Regex regex = new(signs);
                if (regex.IsMatch(filePath))
                {
                    Process.Start(filePath, enterFile);
                }
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Application.EndApp();
        }

        public static void KillAProcess()
        {
            try
            {
                Console.WriteLine("enter process name to kill");
                var enter_process = Console.ReadLine();
                var KillProcess = Process.GetProcesses().Where(pr => pr.ProcessName == enter_process);

                foreach (var proc in KillProcess)
                {
                    proc.Kill();
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            Application.EndApp();
        }

       
    }
}
