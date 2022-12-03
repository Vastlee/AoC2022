namespace Day02;

internal static partial class DayTwo {
    const string inputPath = @"Day02\Day02Input.txt";

    internal static string[] RoundsInput { get; private set; } = File.ReadAllLines(inputPath);

    internal static readonly Dictionary<string, int> StrategyValues = new() {
        { "X", 1 },
        { "Y", 2 },
        { "Z", 3 },
    };

    public static int ShapeValue(Shape s) {
        return s switch {
            Shape.Rock => 1,
            Shape.Paper => 2,
            Shape.Sisscors => 3,
            _ => throw new ArgumentException("Invalid Shape")
        };
    }

    public static Shape ToShape(string s) {
        return s switch {
            "A" or "X" => Shape.Rock,
            "B" or "Y" => Shape.Paper,
            "C" or "Z" => Shape.Sisscors,
            _ => throw new ArgumentException($"{s} is an invalid Shape")
        };
    }
}
