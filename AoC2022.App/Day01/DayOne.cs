namespace Day01;

internal static partial class DayOne {
    const string inputFile = @"Day01\Day01Input.txt";

    static string[] input = File.ReadAllLines(inputFile);

    internal readonly static List<Elf> Elves = initElves();

    static List<Elf> initElves() {
        List<Elf> elves = new();

        Elf newElf = new();
        for(int i = 0; i < input.Length; i++) {
            if(string.IsNullOrEmpty(input[i])) {
                elves.Add(newElf);
                newElf = new();
            } else {
                if(int.TryParse(input[i], out int calorieToAdd)) {
                    newElf.Foods.Add(calorieToAdd);
                }
            }
        }
        elves.Add(newElf);

        return elves;
    }

    public static int HighestCalorieCount(int count = 1) =>
        Elves.OrderByDescending(x => x.Total).Take(count).Sum(x => x.Total);
}
