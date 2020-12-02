using System;
using System.IO;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        IEnumerable<string> lines = File.ReadLines("./Input.txt");
        

        Console.WriteLine($"Part1 correct passwords: {Part1(lines)}");
        Console.WriteLine($"Part2 correct passwords: {Part2(lines)}");
    }

    private static int Part1(IEnumerable<string> lines)
    {
        int totalCorrect = 0;
        foreach(string line in lines)
        {
            string[] args = line.split(' ');

            int lowerBound = Int32.Parse(args[0].split('-')[0]);
            int higherBound = Int32.Parse(args[0].split('-')[0]);

            char check_for = args[0][1];

            string password = args[2];

            int count = 0;
            foreach (char letter in password) {
                if (letter == check_for) {
                    count++;
                }
            }

            if count >= lowerBound && count <= higherBound {
                totalCorrect++;
            }
        }

        return totalCorrect;
    }

    private static int Part2(IEnumerable<string> lines)
    {
        int totalCorrect = 0;
        foreach(string line in lines)
        {
            string[] args = line.split(' ');
        }
    }
}