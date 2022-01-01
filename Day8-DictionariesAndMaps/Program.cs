class Solution
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        var phoneBook = new Dictionary<string, string>();

        for (int i = 0; i < n; i++)
        {
            string[] phoneData= Console.ReadLine().Split(' ');
            phoneBook.Add(phoneData[0], phoneData[1]);
        }

        string searchedName = "";
        while((searchedName = Console.ReadLine()) != null)
        {
            if (phoneBook.ContainsKey(searchedName)) {
                Console.WriteLine(searchedName + " = " + phoneBook[searchedName]);
            }
            else {
                Console.WriteLine("Not found");
            }
        }
    }
}