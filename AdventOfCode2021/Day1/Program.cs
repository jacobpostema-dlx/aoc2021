string[] lines = System.IO.File.ReadAllLines(@"/Users/t463971/code/aoc2021/AdventOfCode2021/Day1/input.txt");
int[] report = Array.ConvertAll(lines, int.Parse);
 
Console.WriteLine("########## Day 1 2020 ##########");
Console.WriteLine($"Part one solution: {SolvePartOne(report)}");
// Console.WriteLine($"Part two solution: {SolvePartTwo(report)}");
Console.WriteLine("################################");

static int SolvePartOne(int[] report)
{
    int increaseNumber = 0;
    for (int i = 1; i < report.Length; i++)
    {
        if(report[i] > report[i - 1])
        {
            increaseNumber++;
        }

    }
    return increaseNumber;
}

