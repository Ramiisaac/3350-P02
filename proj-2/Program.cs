using System;
using System.IO;
using System.Diagnostics;
using System.Text;

namespace proj2
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            string path = Path.GetTempFileName();

            Console.WriteLine("Let's find out how long it takes to open a file: \n");

            Console.WriteLine(" ...initializing stopwatch");
            Stopwatch stopwatch = new Stopwatch();

            Console.WriteLine(" ...starting stopwatch && opening file");
            stopwatch.Start();

            using (FileStream fs = File.Open(path, FileMode.Open, FileAccess.Write, FileShare.None))
            {
                Console.WriteLine(" ...file successfully opened");
            }

            stopwatch.Stop();
            Console.WriteLine("\nTime elapsed: {0}", stopwatch.Elapsed);

            Console.WriteLine("\nEOF - TYPE ANY CHRCTR TO EXIT");
            Console.ReadLine();
        }
    }
}
