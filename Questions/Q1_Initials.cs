namespace CSharpAssignment3.Questions;

public static class Q1_Initials
{
    public static void Run()
    {
        Console.WriteLine("Q1: Initials Generator");

        Console.Write("Enter your full name: ");
        string fullName = Console.ReadLine();

        string[] nameParts = fullName.Trim().Split(' ');
        string initials = "";

        foreach (string part in nameParts)
        {
            initials += part[0].ToString().ToUpper() + ".";
        }

        initials = initials.TrimEnd('.');

        Console.WriteLine("Your initials are: " + initials);
    }
}
