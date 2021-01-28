using System;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Threading.Tasks;

namespace CodeQLpoc
{
    class Program
    {
        static void Main(string[] args)
        {
            //To display file content
            string value = File.ReadAllText(args[0]); // BAD: This could read any file on the file system
            Console.WriteLine(value);

            //To differentiate between Sync and Async
            //Task delay = asyncTask();
            //syncCode();
            //delay.Wait();
            Console.ReadLine();
        }

        static async Task asyncTask()
        {
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("async: Starting");
            Task delay = Task.Delay(5000);
            Console.WriteLine("async: Running for {0} seconds", sw.Elapsed.TotalSeconds);
            await delay;
            Console.WriteLine("async: Running for {0} seconds", sw.Elapsed.TotalSeconds);
            Console.WriteLine("async: Done");
        }

        static void syncCode()
        {
            var sw = new Stopwatch();
            sw.Start();
            Console.WriteLine("sync: Starting");
            Thread.Sleep(5000);
            Console.WriteLine("sync: Running for {0} seconds", sw.Elapsed.TotalSeconds);
            Console.WriteLine("sync: Done");
        }
    }
}
