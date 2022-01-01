abstract class Book
{
    protected string _title;
    protected string _author;
    public Book(string title, string author)
    {
        _title = title;
        _author = author;
    }
    public abstract void display();
}

class MyBook : Book
{
    private int _price;

    public MyBook(string title, string author, int price) : base (title, author)
    {
        _price = price;
    }

    public override void display()
    {
        Console.WriteLine($"Title : {_title}");
        Console.WriteLine($"Author : {_author}");
        Console.WriteLine($"Price : {_price}");
    }
}
class Solution {
    static void Main(string[] args) {
      string? title=Console.ReadLine();
      string? author=Console.ReadLine();
      int price=Int32.Parse(Console.ReadLine());
      Book new_novel=new MyBook(title,author,price);
      new_novel.display();
    }
}