using System;
using System.IO;

namespace WriteStuff2
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

            try
            {
                using (StreamWriter writer = new StreamWriter(filename))
                {
                    while (true)
                    {
                        string input = Console.ReadLine();

                        if (string.IsNullOrEmpty(input))
                            break;

                        writer.WriteLine(input);
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
