using CSharpAssignment3.Questions;

namespace CSharpAssignment3;

class Program
{
    static void Main(string[] args)
    {
        bool running = true;

        while (running)
        {
            Console.WriteLine("\nAssignment 3 - Choose a question");
            Console.WriteLine("1.  Initials Generator");
            Console.WriteLine("2.  Password Checker");
            Console.WriteLine("3.  String Reversal");
            Console.WriteLine("4.  Employee Class");
            Console.WriteLine("5.  Book Class");
            Console.WriteLine("6.  Simple Calculator");
            Console.WriteLine("7.  Browser Back Button");
            Console.WriteLine("8.  Hospital Queue");
            Console.WriteLine("9.  Student Score Manager");
            Console.WriteLine("10. Phonebook App");
            Console.WriteLine("0.  Exit");
            Console.Write("Enter your choice: ");

            string input = Console.ReadLine();

            Console.WriteLine();

            if (input == "1")       Q1_Initials.Run();
            else if (input == "2")  Q2_PasswordChecker.Run();
            else if (input == "3")  Q3_StringReversal.Run();
            else if (input == "4")  Q4_Employee.Run();
            else if (input == "5")  Q5_Book.Run();
            else if (input == "6")  Q6_Calculator.Run();
            else if (input == "7")  Q7_BrowserBack.Run();
            else if (input == "8")  Q8_HospitalQueue.Run();
            else if (input == "9")  Q9_StudentScores.Run();
            else if (input == "10") Q10_Phonebook.Run();
            else if (input == "0")  running = false;
            else Console.WriteLine("Invalid choice.");

            if (running)
            {
                Console.WriteLine("\nPress any key to go back to the menu...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
