using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AOC2020
{
    public static class Day1
    {
        public static async Task Part1()
        {
            var inputLines = await File.ReadAllLinesAsync(@"Day1.txt").ConfigureAwait(false); 

            for (int i = 0; i < inputLines.Count(); i++)
            {
                var number1 = int.Parse(inputLines[i]);

                for (int j = i + 1; j < inputLines.Count() ; j++)
                {
                    var number2 = int.Parse(inputLines[j]);
                    if(number1 + number2 == 2020)
                    {
                        Console.WriteLine($"The answer is {number1 * number2}");
                        Console.ReadKey();
                    }
                } 
            }

            Console.WriteLine($"The answer is wasn't found");
            Console.ReadKey();
        }

        public static async Task Part2()
        {
            var inputLines = await File.ReadAllLinesAsync(@"Day1.txt").ConfigureAwait(false);

            for (int i = 0; i < inputLines.Count(); i++)
            {
                var number1 = int.Parse(inputLines[i]);

                for (int j = i + 1; j < inputLines.Count(); j++)
                {
                    var number2 = int.Parse(inputLines[j]);

                    for (int k = j+1; k < inputLines.Count(); k++)
                    {
                        var number3 = int.Parse(inputLines[k]);
                        if (number1 + number2 + number3 == 2020)
                        {
                            Console.WriteLine($"The answer is {number1 * number2 * number3}");
                            Console.ReadKey();
                        }
                    } 
                }
            }

            Console.WriteLine($"The answer is wasn't found");
            Console.ReadKey();
        }
    }
}
