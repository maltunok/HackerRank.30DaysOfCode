class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        Regex regex = new Regex(@"[a-z]+@gmail\.com$");

        List<string> names = new();

        for (int i = 0; i < n; i++)
        {
            string[] firstMultipleInput = Console.ReadLine().TrimEnd().Split(' ');

            string firstName = firstMultipleInput[0];

            string emailID = firstMultipleInput[1];

            if (regex.IsMatch(emailID))
            {
                names.Add(firstName);
            }
        }

        names.Sort();

        foreach (var name in names)
        {
            Console.WriteLine(name);
        }
    }
}
