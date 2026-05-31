namespace Assessment
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LibraryManager manager = new LibraryManager();
            bool exit = false;

            do
            {
                Console.WriteLine("\n LIBRARY MANAGEMENT SYSTEM ");
                Console.WriteLine("1.  Add Book");
                Console.WriteLine("2.  Remove Book");
                Console.WriteLine("3.  Find Book by ISBN");
                Console.WriteLine("4.  Request Borrow");
                Console.WriteLine("5.  Process Next Borrow Request");
                Console.WriteLine("6.  Undo Last Action");
                Console.WriteLine("7.  Display Categories");
                Console.WriteLine("8.  Display All Books");
                Console.WriteLine("9.  Display Books Sorted by Title");
                Console.WriteLine("10. Library Statistics");
                Console.WriteLine("0.  Exit");
                Console.Write("Select Option: ");

                int option = int.Parse(Console.ReadLine()!);

                switch (option)
                {
                    case 1:
                        Console.Write("ISBN: "); string isbn = Console.ReadLine()!;
                        Console.Write("Title: "); string title = Console.ReadLine()!;
                        Console.Write("Author: "); string author = Console.ReadLine()!;
                        Console.Write("Category: "); string category = Console.ReadLine()!;
                        manager.AddBook(isbn, title, author, category);
                        break;
                    case 2:
                        Console.Write("Enter ISBN to remove: ");
                        manager.RemoveBook(Console.ReadLine()!);
                        break;
                    case 3:
                        Console.Write("Enter ISBN to find: ");
                        manager.FindBook(Console.ReadLine()!);
                        break;
                    case 4:
                        Console.Write("Member ID: "); int id = int.Parse(Console.ReadLine()!);
                        Console.Write("Member Name: "); string name = Console.ReadLine()!;
                        manager.RequestBorrow(id, name);
                        break;
                    case 5:
                        manager.ProcessNextBorrow();
                        break;
                    case 6:
                        manager.UndoLastAction();
                        break;
                    case 7:
                        manager.displayCategories();
                        break;
                    case 8:
                        manager.displayAllBooks();
                        break;
                    case 9:
                        manager.displaySortedByTitle();
                        break;
                    case 10:
                        manager.displayStatistics();
                        break;
                    case 0:
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid option. Try again.");
                        break;
                }
            } while (!exit);
        }
    }
}