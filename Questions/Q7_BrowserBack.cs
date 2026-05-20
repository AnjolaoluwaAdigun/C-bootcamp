using System.Collections;

namespace CSharpAssignment3.Questions;

public static class Q7_BrowserBack
{
    public static void Run()
    {
        Console.WriteLine("Q7: Browser Back Button");

        Stack history = new Stack();
        string currentPage = "";
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1. Visit a page");
            Console.WriteLine("2. Go back");
            Console.WriteLine("0. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter URL: ");
                string url = Console.ReadLine();

                if (currentPage != "")
                    history.Push(currentPage);

                currentPage = url;
                Console.WriteLine("Now visiting: " + currentPage);
            }
            else if (choice == "2")
            {
                if (history.Count == 0)
                {
                    Console.WriteLine("No pages to go back to.");
                }
                else
                {
                    currentPage = history.Pop().ToString();
                    Console.WriteLine("Went back to: " + currentPage);
                }
            }
            else if (choice == "0")
            {
                running = false;
            }
            else
            {
                Console.WriteLine("Invalid option.");
            }
        }
    }
}
