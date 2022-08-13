using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            ProcessStartInfo StartInfo = new System.Diagnostics.ProcessStartInfo
            {
                UseShellExecute = false, 
                WorkingDirectory = Environment.CurrentDirectory,
                UserName = "user2",
                Password = MakeSecureString("Passw0rd"),
                FileName = "ElevatePrivs.exe",
            };

            Process.Start(StartInfo);

            SecureString MakeSecureString(string password)
            {
                SecureString secure = new SecureString();
                foreach (char c in password)
                {
                    secure.AppendChar(c);
                }

                return secure;
            }
        }
    }
}
