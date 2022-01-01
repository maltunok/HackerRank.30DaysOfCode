class Solution
{
    public static void Main(string[] args)
    {
        string? s  = Console.ReadLine();

        try
        {
            var i = int.Parse(s);
            Console.WriteLine(i);
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}