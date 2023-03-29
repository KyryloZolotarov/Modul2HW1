using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW1
{
    internal class Logger
    {
        private static Logger? instance;
        private readonly LogStorage _storage;
        private Logger()
        {
            _storage = new LogStorage();
        }

        public static Logger GetInstance()
        {
            instance ??= new Logger();

            return instance;
        }

        public void LogInfo(string message)
        {
            Log(LogLevel.Info, message);
        }

        public void LogWarning(string message)
        {
            Log(LogLevel.Warning, message);
        }

        public void LogError(string message)
        {
            Log(LogLevel.Error, message);
        }

        public void DispLog()
        {
            _storage.DisplayLogs();
        }

        public void SaveLogs()
        {
            _storage.SaveLogsToFile("OutputLogs.txt");
        }

        private void Log(LogLevel level, string message)
        {
            _storage.StoreLog($"{DateTime.Now.ToShortTimeString()}: {level} : {message}");
        }
    }
}
