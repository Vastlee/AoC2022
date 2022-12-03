namespace Day02;

internal class Round {
    public Shape Them { get; set; }
    public Shape You { get; set; }

    public RoundResult Result => GetResult();
    public int Score => GetScore();

    public Round(string[] input) {
        Them = DayTwo.ToShape(input[0]);
        You = DayTwo.ToShape(input[1]);
    }

    int GetScore() {
        const int WIN = 6;
        const int DRAW = 3;

        int score = DayTwo.ShapeValue(You);

        if(Result == RoundResult.Win) { score += WIN; }
        if(Result == RoundResult.Draw) { score += DRAW; }

        return score;
    }

    RoundResult GetResult() {
        if(You == Them) { return RoundResult.Draw; }

        if((You == Shape.Rock && Them == Shape.Sisscors)
            || (You == Shape.Paper && Them == Shape.Rock)
            || (You == Shape.Sisscors && Them == Shape.Paper)) {
            return RoundResult.Win;
        }

        return RoundResult.Lose;
    }
}
