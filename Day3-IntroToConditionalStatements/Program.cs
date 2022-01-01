class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine()?.Trim());

        if (n %2 == 1 || (n >= 6 && n <= 20))
        {
            Console.WriteLine("Weird");
        }
        else {
            Console.WriteLine("Not Weird");
        }
    }
}
