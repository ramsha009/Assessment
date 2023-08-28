using System;
using System.IO;
using System.Linq;

namespace NameSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.WriteLine("Usage: name-sorter <input-file>");
                return;
            }

            string inputFilePath = args[0];
            string[] names = File.ReadAllLines(inputFilePath);

            var sortedNames = names.OrderBy(name => name.Split().Last()).ThenBy(name => name).ToArray();

            Console.WriteLine("Sorted names:");
            foreach (var name in sortedNames)
            {
                Console.WriteLine(name);
            }

            string outputFilePath = "sorted-names-list.txt";
            File.WriteAllLines(outputFilePath, sortedNames);
            Console.WriteLine($"Sorted names have been saved to {outputFilePath}");
        }
    }
}
