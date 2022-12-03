namespace Day01;

internal static class PartOne {
    internal static int HighestCalorieCount() {
        return DayOne.Elves.OrderByDescending(x => x.Total).Take(1).Sum(x => x.Total);
    }
}