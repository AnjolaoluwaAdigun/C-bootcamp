namespace CSharpAssignment3.Questions;

public static class Q2_PasswordChecker
{
    public static void Run()
    {
        Console.WriteLine("Q2: Password Checker");

        Console.Write("Enter a password: ");
        string password = Console.ReadLine();

        bool isLongEnough = password.Length >= 8;
        bool hasWeakPattern = password.Contains("123");

        if (!isLongEnough)
        {
            Console.WriteLine("Weak password - must be at least 8 characters.");
        }
        else if (hasWeakPattern)
        {
            Console.WriteLine("Weak password - avoid using '123' in your password.");
        }
        else
        {
            Console.WriteLine("Strong password!");
        }
    }
}
