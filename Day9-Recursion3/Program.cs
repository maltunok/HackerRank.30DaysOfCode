class Result
{
    public static int factorial (int n)
    {
        return (n > 1)? n * factorial(n-1) : 1;
    }
}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        int result = Result.factorial(n);

        Console.WriteLine(result);
    }
}
     
