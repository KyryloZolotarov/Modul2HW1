using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW1
{
    internal class LogStorage
    {
        private List<string> Logs { get; set; } = new List<string>();
        public void StoreLog(string message)
        {
            Logs.Add(message);
        }

        public void DisplayLogs()
        {
            foreach (string dLog in Logs)
            {
                Console.WriteLine(dLog);
            }
        }

        public void SaveLogsToFile(string filename)
        {
            File.WriteAllText(filename, string.Join(Environment.NewLine, Logs));
        }
    }
}
