using System;
using System.Collections.Generic;

namespace GCIssueExample1
{
  
    class Program
    {
        private static List<int[]> arrays = new List<int[]>();
        private static Random rand = new Random();


        static void Main(string[] args)
        {
            Console.WriteLine("Which proces do you want to start?");
            Console.WriteLine("1: Process which keeps reference to created array in another array.");
            Console.WriteLine("2: Program which creates a new array but doesn't keep a reference.");
            string key = Console.ReadLine();

            
            
            if(key == "1")
            {
                Console.WriteLine("Starting ProcessWhichKeepsReference...");
                Console.WriteLine("Press any key to exit...");
                ProcessWhichKeepsReference();
            }
            else
            {
                Console.WriteLine("Starting ProcessWhichDoesNotKeepsReference...");
                Console.WriteLine("Press any key to exit...");
                ProcessWhichDoesNotKeepsReference();
            }

            Console.WriteLine("Done, exiting");
        }

        static void ProcessWhichKeepsReference()
        {

            while (!Console.KeyAvailable)
            {
                int size = rand.Next(1024, 100000);
                int[] newArray = new int[size];
                arrays.Add(newArray);
                System.Threading.Thread.Sleep(10);
            }
        }

        static void ProcessWhichDoesNotKeepsReference()
        {
            while (!Console.KeyAvailable)
            {

                var byteArray = new byte[100 * 1000];
                Console.WriteLine($"Length of byte {byteArray.Length}.");
                System.Threading.Thread.Sleep(10);
            }
        }
    }
}
