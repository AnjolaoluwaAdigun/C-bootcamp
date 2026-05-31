namespace Assessment
{
    public class LibraryManager
    {
        public List <Book> allBooks= new List<Book> ();
        public Dictionary<string,Book> isbnLookup =new Dictionary<string, Book>();

        public Queue<Member> borrowRequest =new Queue<Member>();
        public Stack<string> actionHistory = new Stack<string>();
        public  HashSet<string> bookCategories=new HashSet<string>();

        public void AddBook(string isbn, string title, string author, string category)
            {
               Book addition= new Book(); 
               addition.ISBN=isbn;
               addition.Title=title;
               addition.Author=author;
               addition.Category=category;
               addition.IsAvailable=true;

               allBooks.Add(addition);
               isbnLookup[isbn]=addition;
               bookCategories.Add(category);
               actionHistory.Push($"Added{addition.Title} to the library");

            }

        public void RemoveBook(string isbn)
        {
            if (isbnLookup.TryGetValue(isbn, out Book? book))
                {
                   allBooks.Remove(book);
                   isbnLookup.Remove(isbn);
                   actionHistory.Push($"Removed book: {book.Title}");
                }
                else
                {
                    Console.WriteLine("Book not found.");
                }
        }
        public void FindBook(string isbn)
        {
            if(isbnLookup.TryGetValue(isbn,out Book? book))
            {
                Console.WriteLine($"ISBN: {book.ISBN}, Title: {book.Title}, Author: {book.Author}, Category: {book.Category}, Available: {book.IsAvailable}");
            }
            else
            {
                Console.WriteLine("Book not found.");
            }
        }

        public void RequestBorrow(int MemberId, string name)
        {
            Member member1= new Member();
            member1.MemberId=MemberId;
            member1.Name=name;
            borrowRequest.Enqueue(member1);
        }             

        public void ProcessNextBorrow()
        {
            Member next = borrowRequest.Dequeue();
            Console.WriteLine($"Serving: {next.Name}");
        }

        public void UndoLastAction()
        {
            Console.WriteLine(actionHistory.Pop());
        }

        public void displayCategories()
        {
            foreach (string category in bookCategories)
            {
                Console.WriteLine (category);
            }
        }

        public void displayAllBooks()
        {
            foreach (Book book in allBooks)
            {
                Console.WriteLine($"ISBN: {book.ISBN}, Title: {book.Title}, Author: {book.Author}, Category: {book.Category}, Available: {book.IsAvailable}");
            }
        }

        public void displaySortedByTitle()
        {
            allBooks.Sort((a, b) => a.Title.CompareTo(b.Title));
             foreach (Book book in allBooks)
            {
                Console.WriteLine($"ISBN: {book.ISBN}, Title: {book.Title}, Author: {book.Author}, Category: {book.Category}, Available: {book.IsAvailable}");
            }
        }

        public void displayStatistics()
        {
            int total= allBooks.Count;
            Console.WriteLine($"Total number of books:{total}");
            int available = allBooks.Count(b => b.IsAvailable == true);
            Console.WriteLine($"Total available number of books:{available}");
            int borrowed = allBooks.Count(b => b.IsAvailable == false);
            Console.WriteLine($"Total borrowed number of books:{borrowed}");
            Console.WriteLine($"Number of categories{bookCategories.Count}");

        }
    }
}
    
