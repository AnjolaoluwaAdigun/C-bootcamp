namespace CSharpAssignment3.Questions;

public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public double Price { get; set; }
    public int Pages { get; set; }

    public Book(string title, string author, double price, int pages)
    {
        Title = title;
        Author = author;
        Price = price;
        Pages = pages;
    }

    public bool IsBestSeller(int sales)
    {
        return sales > 10000;
    }

    public void DisplayInfo(int sales)
    {
        Console.WriteLine("Title: " + Title);
        Console.WriteLine("Author: " + Author);
        Console.WriteLine("Price: " + Price);
        Console.WriteLine("Pages: " + Pages);
        Console.WriteLine("Sales: " + sales);

        if (IsBestSeller(sales))
        {
            Console.WriteLine("Bestseller: Yes");
        }
        else
        {
            Console.WriteLine("Bestseller: No");
        }

        Console.WriteLine();
    }
}

public static class Q5_Book
{
    public static void Run()
    {
        Console.WriteLine("Q5: Book Class");
        Console.WriteLine();

        Book book1 = new Book("Things Fall Apart", "Chinua Achebe", 4500, 209);
        Book book2 = new Book("Purple Hibiscus", "Chimamanda Adichie", 5200, 307);
        Book book3 = new Book("Half of a Yellow Sun", "Chimamanda Adichie", 6000, 433);

        book1.DisplayInfo(52000);
        book2.DisplayInfo(8500);
        book3.DisplayInfo(14200);
    }
}
