namespace Day02;

internal static class PartTwo {
    public static int Score() {
        int result = 0;
        foreach(string roundInput in DayTwo.RoundsInput) {
            Round round = new(roundInput.Split());
            CorrectShape(round);
            result += round.Score;
        }

        return result;
    }

    static void CorrectShape(Round round) {
        if(ShouldDraw(round)) {
            round.You = round.Them;
            return;
        }

        if(ShouldLose(round)) {
            if(round.Them == Shape.Rock) { round.You = Shape.Sisscors; }
            if(round.Them == Shape.Paper) { round.You = Shape.Rock; }
            if(round.Them == Shape.Sisscors) { round.You = Shape.Paper; }
            return;
        }

        if(ShouldWin(round)) {
            if(round.Them == Shape.Rock) { round.You = Shape.Paper; }
            if(round.Them == Shape.Paper) { round.You = Shape.Sisscors; }
            if(round.Them == Shape.Sisscors) { round.You = Shape.Rock; }
        }

        static bool ShouldDraw(Round round) => round.You == Shape.Paper;
        static bool ShouldLose(Round round) => round.You == Shape.Rock;
        static bool ShouldWin(Round round) => round.You == Shape.Sisscors;
    }
}