using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Pipes;

namespace ConsoleTaskManager
{
    public class DisplayProcesses
    {
        public static void EnumeratingProcesses()
        {
            var RunningProcess = from proc in Process.GetProcesses()
                                 orderby proc.Id
                                 select proc;

            foreach (var p in RunningProcess)
            {
                string info = $"-> PID: {p.Id}\tName: {p.ProcessName}";
                Console.WriteLine(info);
            }
            Console.WriteLine("***********************************************\n");

            Application.EndApp();
        }
    }
}
