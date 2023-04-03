using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Modul2HW1
{
    internal class Starter
    {
        public void Run()
        {
            for (int i = 0; i < 100; i++)
            {
                var rand = new Random();
                var methodN = rand.Next(1, 4);
                if (methodN == 1)
                {
                    CheckRes(new Action().Start());
                }

                if (methodN == 2)
                {
                    CheckRes(new Action().SkippLogic());
                }

                if (methodN == 3)
                {
                    CheckRes(new Action().BrokeLogic());
                }
            }
        }

        private void CheckRes(Result result)
        {
            if (result.Status == false)
            {
                Logger.GetInstance().LogError($"Action failed by а reason:{result.Message}");
            }
        }
    }
}
