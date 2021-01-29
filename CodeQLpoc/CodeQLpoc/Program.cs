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
            ReadFile(args[0]);

            //To differentiate between Sync and Async
            //Task delay = asyncTask();
            //syncCode();
            //delay.Wait();
            Console.ReadLine();
        }

        static void ReadFile(string path)
        {
            //To display file content
            StreamReader reader = new StreamReader(path);
            string value = reader.ReadToEnd(); // BAD: This could read any file on the file system
            Console.WriteLine(value);
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
