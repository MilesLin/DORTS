using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Parallel_Demo
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] files = Directory.GetFiles("../../TestFiles");

            var watch = new Stopwatch();

            watch.Start();

            Parallel.ForEach(files, (currentFile) =>
            {
                string filename = Path.GetFileName(currentFile);
                Console.WriteLine($"Processing {filename} on thread {Thread.CurrentThread.ManagedThreadId}");
            });
            
            watch.Stop();

            Console.WriteLine("Consume Time: {0} ms", watch.ElapsedMilliseconds);
        }
    }
}
