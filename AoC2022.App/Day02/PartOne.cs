namespace Day02;

internal static class PartOne {
    public static int Score() {
        int result = 0;

        foreach(string roundInput in DayTwo.RoundsInput) {
            Round round = new(roundInput.Split());
            result += round.Score;
        }

        return result;
    }
}
