class Solution
{
    public static void Main(string[] args)
    {
        double mealCost = Convert.ToDouble(Console.ReadLine()?.Trim());
        int tipPercent = Convert.ToInt32(Console.ReadLine()?.Trim());
        int taxPercent = Convert.ToInt32(Console.ReadLine()?.Trim());

        Result.solve(mealCost, tipPercent, taxPercent);
    }
}

class Result 
{
    public static void solve (double mealCost, int tipPercent, int taxPercent)
    {
        double totalCost = mealCost + mealCost * tipPercent / 100 + mealCost * taxPercent / 100;
        System.Console.WriteLine(Math.Round(totalCost));
    }
}
