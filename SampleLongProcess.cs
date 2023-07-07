using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwaitTasksSample
{
    public class SampleLongProcess
    {
        public static void LongProcess()
        {
            Console.WriteLine("Start LongProcess ... ");
            System.Threading.Thread.Sleep(5000);
            Console.WriteLine("LongProcess Completed.");
        }

        public static async void LongAsyncProcess()
        {
            Console.WriteLine("Start LongAsyncProcess ... ");
            await Task.Delay(5000);
            Console.WriteLine("LongAsyncProcess Completed.");
        }

        public static async Task<int> LongAsyncTaskProcess()
        {
            Console.WriteLine("Start LongAsyncProcess ... ");
            await Task.Delay(5000);
            Console.WriteLine("LongAsyncProcess Completed.");
            return 10;
        }
    }
}
