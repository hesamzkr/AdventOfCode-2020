using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

class MainClass
{
    public static void Main(string[] args)
    {
        List<string> numbers = File.ReadLines("./Input.txt").ToList();

        Console.WriteLine($"Part1 value: {Part1(numbers)}");
        //Console.WriteLine($"Part2 value: {Part2(instructions)}");
    }

    private static int Part1(List<string> numbers, int preambleLength)
    {

    }


    private static bool Validator()
    {

    }
}