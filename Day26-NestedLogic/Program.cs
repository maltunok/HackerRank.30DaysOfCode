class Solution
{
    static void Main(string[] args)
    {
        string[] returnedDateStr = Console.ReadLine().Split(' ');
        int returnedDateDay  = int.Parse(returnedDateStr[0]);
        int returnedDateMonth  = int.Parse(returnedDateStr[1]);
        int returnedDateYear  = int.Parse(returnedDateStr[2]);

        string[] dueDateStr = Console.ReadLine().Split(' ');
        int dueDateDay  = int.Parse(dueDateStr[0]);
        int dueDateMonth  = int.Parse(dueDateStr[1]);
        int dueDateYear  = int.Parse(dueDateStr[2]);

        DateTime returnedDate = new DateTime(returnedDateYear, returnedDateMonth, returnedDateDay);

        DateTime dueDate = new DateTime(dueDateYear, dueDateMonth, dueDateDay);

        NestedLogic(dueDate, returnedDate);
    }

    private static void NestedLogic(DateTime dueDate, DateTime rerturnedDate)
    {
        int fine = 0;

        fine = (rerturnedDate) <= dueDate ? 0 : 
        (rerturnedDate.Month == dueDate.Month && rerturnedDate.Year == dueDate.Year)? 15 * (rerturnedDate.Day - dueDate.Day) :
        (rerturnedDate.Year == dueDate.Year)? 500 * (rerturnedDate.Month - dueDate.Month) :
        10000;
        
        Console.WriteLine(fine);
    }
}