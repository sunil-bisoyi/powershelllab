using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;             // Windows PowerShell namespace.
using System.Management.Automation.Runspaces;   // Windows PowerShell namespace
namespace Powershelllab
{
    class Program
    {

        public static void Main(string[] args)
        {
            // Testing 

            WSManConnectionInfo connectionInfo = new WSManConnectionInfo();
            

            connectionInfo.OperationTimeout = 4 * 60 * 1000; // 4 minutes.


            connectionInfo.OpenTimeout = 1 * 60 * 1000; // 1 minute.


            //foreach (var process in PowerShell.Create().AddCommand("Get-Process").Invoke())
            //{
            //    Console.WriteLine(process.Properties["ProcessName"].Value);
            //} 




            }

  
        }
    }


