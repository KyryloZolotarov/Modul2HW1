using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW1
{
    internal class Action
    {
        public Result Start()
        {
            Logger.GetInstance().LogInfo($"Start method: Start");
            var res = new Result();
            res.Status = true;
            return res;
        }

        public Result SkippLogic()
        {
            Logger.GetInstance().LogWarning($"Skipped logic in method: SkippLogic");
            var res = new Result();
            res.Status = true;
            return res;
        }

        public Result BrokeLogic()
        {
            var res = new Result();
            res.Status = false;
            res.Message = "I broke a logic";
            return res;
        }
    }
}
