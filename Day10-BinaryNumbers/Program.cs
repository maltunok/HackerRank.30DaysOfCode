class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());
        Console.WriteLine(Convert.ToString(n, 2));
        var remainder = 0;
        var count = 0;
        var max = 0;

        while (n > 0)
        {
            remainder = n % 2;
            n /= 2;

            if (remainder == 1)
            {
                count++;
                max = Math.Max(max, count);
            }
            else{
                count = 0;
            }
        }

        Console.WriteLine(max);
    }
}