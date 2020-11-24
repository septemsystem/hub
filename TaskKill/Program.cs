using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskKill
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime();
            DateTime date2 = new DateTime(2020, 11, 24, 23, 0, 0);
            int result = DateTime.Compare(date1, date2);

            Console.WriteLine("12");

            if (result > 0)

            {
                Process[] processes = Process.GetProcessesByName("clickermann");
                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }

            else
            {
                Environment.Exit(0);
            } 
           
        }
    }
}
