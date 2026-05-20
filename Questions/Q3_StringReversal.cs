namespace CSharpAssignment3.Questions;

public static class Q3_StringReversal
{
    public static void Run()
    {
        Console.WriteLine("Q3: String Reversal");

        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        string reversed = "";

        for (int i = input.Length - 1; i >= 0; i--)
        {
            reversed += input[i];
        }

        Console.WriteLine("Reversed: " + reversed);
    }
}
