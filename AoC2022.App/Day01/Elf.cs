namespace Day01;

internal static partial class DayOne {
    internal class Elf {
        public List<int> Foods { get; init; } = new();
        public int Total => Foods.Sum();
    }
}
