string[] lines = System.IO.File.ReadAllLines(@"/Users/t463971/code/aoc2021/AdventOfCode2021/Day2/input.txt");
var commands = new List<KeyValuePair<string, int>>();

foreach (var line in lines)
{
    string[] command = line.Split(' ');
    commands.Add(new KeyValuePair<string, int>(command[0], int.Parse(command[1])));
}

Console.WriteLine("########## Day 2 2021 ##########");
Console.WriteLine($"Part one solution: {SolvePartOne(commands)}");
Console.WriteLine($"Part two solution: {SolvePartTwo(commands)}");
Console.WriteLine("################################");

static int SolvePartOne(List<KeyValuePair<string, int>> commands)
{
    var horizontal_position = 0;
    var depth = 0;

    foreach (var item in commands)
    {
        switch (item.Key)
        {
            case "forward":
                horizontal_position += item.Value;
                break;
            
            case "down":
                depth += item.Value;
                break;

            case "up":
                depth -= item.Value;
                break;
            default:
                break;
        }
    }

    return depth * horizontal_position;
}

static int SolvePartTwo(List<KeyValuePair<string, int>> commands)
{   
    return 1;
}