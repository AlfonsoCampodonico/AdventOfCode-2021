namespace AdventOfCode;

public class Day_01 : BaseDay
{
    private readonly string[] _input;
    private readonly int[] _numbers;

    public Day_01()
    {
        _input = File.ReadAllLines(InputFilePath);
        _numbers = _input.Select(x => int.Parse(x)).ToArray();
    }

    public override  ValueTask<string> Solve_1() => new($"Solution to {ClassPrefix} {CalculateIndex()}, part 1 is { Solution1()}");
        
    public override ValueTask<string> Solve_2() => new($"Solution to {ClassPrefix} {CalculateIndex()}, part 2 is { Solution2()}");



    private int Solution1()
    {
        return _numbers.Zip(_numbers.Skip(1), (a, b) => a < b).Count(x => x);
    }

    private int Solution2()
    {
        return _numbers.Zip(_numbers.Skip(3), (a, b) => a < b).Count(x => x);
    }

}
