using System;
using System.Collections.Generic;
using System.IO;

namespace WriteStuff1
{
    public class Program
    {
        private static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                Console.WriteLine("Falta o nome do ficheiro.");
                return;
            }

            string filename = args[0];

            Queue<string> inputQueue = new Queue<string>();

            while (true)
            {
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                    break;

                inputQueue.Enqueue(input);
            }

            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    foreach (string line in inputQueue)
                    {
                        writer.WriteLine(line);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
