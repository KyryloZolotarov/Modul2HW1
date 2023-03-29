using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Modul2HW1
{
    internal class DialogWindow
    {
        public static void StartProg()
        {
            Console.Write("To run new logs recording press \"Enter\", to load saved logs press \"Spacebar\"");
            Console.WriteLine();
            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.Enter)
            {
                new Starter().Run();
            }

            if (key == ConsoleKey.Spacebar)
            {
                string basePath = Environment.CurrentDirectory;
                var path = basePath + "\\OutputLogs.txt";
                if (File.Exists(path) == true)
                {
                    var log = File.ReadAllLines(path);
                    foreach (var line in log)
                    {
                        Console.WriteLine(line);
                    }

                    Console.WriteLine();
                    Console.WriteLine("To run new logs recording press \"Enter\"");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        new Starter().Run();
                    }
                }
                else
                {
                    Console.WriteLine("No saved logs");
                    Console.WriteLine("To run new logs recording press \"Enter\"");
                    if (Console.ReadKey().Key == ConsoleKey.Enter)
                    {
                        new Starter().Run();
                    }
                }
            }
        }

        public static void ShowLogs()
        {
            Console.WriteLine("To display logs in console press \"Enter\":");
            if (Console.ReadKey().Key == ConsoleKey.Enter)
            {
                Logger.GetInstance().DispLog();
            }
        }

        public static void StartSaveDial()
        {
            Console.WriteLine("To save logs in txt press \"Enter\", to exit press \"Esc\":");
            var key = Console.ReadKey().Key;
            if (key == ConsoleKey.Enter)
            {
                Logger.GetInstance().SaveLogs();
            }

            if (key == ConsoleKey.Escape)
            {
                Environment.Exit(0);
            }
        }
    }
}
