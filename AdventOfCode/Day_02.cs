using System.Runtime.InteropServices.ComTypes;

namespace AdventOfCode;

public class Day_02 : BaseDay
{
    private readonly string[] _input;

    public Day_02()
    {
        _input = File.ReadAllLines(InputFilePath);
    }


    public override  ValueTask<string> Solve_1() => new($"Solution to {ClassPrefix} {CalculateIndex()}, part 1 is { Solve().P1}");
        
    public override ValueTask<string> Solve_2() => new($"Solution to {ClassPrefix} {CalculateIndex()}, part 2 is { Solve().P2}");



    public (long P1,  long P2) Solve() {

        long horizontal = 0;
        long depth = 0;
        long aim = 0;

        long horizontalP2 = 0;
        long depthP2 = 0;

        for(int i = 0; i < _input.Length; i++) {
            string[] split = _input[i].Split();

            switch (split[0]) {
                case "down":
                    depth += long.Parse(split[1]);
                    aim += long.Parse(split[1]);
                    break;
                case "forward":
                    horizontal += long.Parse(split[1]);
                    horizontalP2 += long.Parse(split[1]);
                    depthP2 += (aim * long.Parse(split[1]));
                    break;
                case "up":
                    depth -= long.Parse(split[1]);
                    aim -= long.Parse(split[1]);
                    break;
                default:
                    break;
            }
        }
        return (horizontal * depth,horizontalP2*depthP2);
    }
    //1762050  1855892637
}
