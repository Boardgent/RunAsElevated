using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElevatePrivs
{
    class Program
    {
        static void Main(string[] args)
        {
            ProcessStartInfo StartInfo = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = true, //<- for elevation
                Verb = "runas",  //<- for elevation
                WorkingDirectory = Environment.CurrentDirectory,
                FileName = "cmd.exe",
                Arguments = "/k whoami /priv"
            };

            Process.Start(StartInfo);
        }
    }
}
