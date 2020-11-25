using System;
using System.Diagnostics;


namespace TaskKill
{
    class Program
    {
        static void Main(string[] args)
        {   
            // Программа срабатывает только до 13:00

            DateTime date1 = DateTime.Now;
            DateTime date2 = new DateTime(2020, 11, 25, 13, 0, 0);
            int result = DateTime.Compare(date1, date2);

            if (result < 0)

                // Перебираем все процессы с заданным именем и убиваем
            {
                Process[] processes = Process.GetProcessesByName("clickermann");
                foreach (Process process in processes)
                {
                    process.Kill();
                }
            }
                // Если процессов нет, то завершаем программу
            else
            {
                Environment.Exit(0);
            } 
           
        }
    }
}
