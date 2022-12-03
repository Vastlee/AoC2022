namespace Day01;

internal static class PartTwo {
    internal static int TopThreeCalorieCounts() {
        return DayOne.Elves.OrderByDescending(x => x.Total).Take(3).Sum(x => x.Total);
    }
}