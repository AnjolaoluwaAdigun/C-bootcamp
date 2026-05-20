namespace CSharpAssignment3.Questions;

public class SimpleCalculator
{
    private double Memory = 0;

    public double Add(double a, double b)
    {
        return a + b;
    }

    public double Subtract(double a, double b)
    {
        return a - b;
    }

    public double Multiply(double a, double b)
    {
        return a * b;
    }

    public double Divide(double a, double b)
    {
        if (b == 0)
        {
            Console.WriteLine("Error: Cannot divide by zero.");
            return 0;
        }
        return a / b;
    }

    public void SaveToMemory(double value)
    {
        Memory = value;
        Console.WriteLine("Saved " + value + " to memory.");
    }

    public double RecallMemory()
    {
        Console.WriteLine("Memory value: " + Memory);
        return Memory;
    }
}

public static class Q6_Calculator
{
    public static void Run()
    {
        Console.WriteLine("Q6: Simple Calculator");

        SimpleCalculator calc = new SimpleCalculator();
        double result = 0;
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add");
            Console.WriteLine("2. Subtract");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            Console.WriteLine("5. Save to Memory");
            Console.WriteLine("6. Recall Memory");
            Console.WriteLine("0. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "0")
            {
                running = false;
            }
            else if (choice == "5")
            {
                calc.SaveToMemory(result);
            }
            else if (choice == "6")
            {
                result = calc.RecallMemory();
            }
            else if (choice == "1" || choice == "2" || choice == "3" || choice == "4")
            {
                Console.Write("Enter first number: ");
                double a = double.Parse(Console.ReadLine());

                Console.Write("Enter second number: ");
                double b = double.Parse(Console.ReadLine());

                if (choice == "1")
                    result = calc.Add(a, b);
                else if (choice == "2")
                    result = calc.Subtract(a, b);
                else if (choice == "3")
                    result = calc.Multiply(a, b);
                else if (choice == "4")
                    result = calc.Divide(a, b);

                Console.WriteLine("Result: " + result);
            }
            else
            {
                Console.WriteLine("Invalid choice.");
            }
        }
    }
}
