using System;

namespace MyApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // --- Q1: Overloaded Describe ---
            Describe("Jola");
            Describe("Jola", 22);
            Describe("Jola", 22, "Lagos");

            Console.WriteLine();

            // --- Q2: FixScore with ref ---
            int score1 = -5;
            int score2 = 110;
            int score3 = 75;

            FixScore(ref score1);
            FixScore(ref score2);
            FixScore(ref score3);

            Console.WriteLine($"Fixed scores: {score1}, {score2}, {score3}");

            Console.WriteLine();

            // --- Q3: FindHighest with params ---
            int highest = FindHighest(4, 17, 3, 99, 42);
            Console.WriteLine($"Highest: {highest}");

            Console.WriteLine();

            // --- Q4: Overloaded Volume ---
            Console.WriteLine($"Cube volume: {Volume(3.0)}");
            Console.WriteLine($"Box volume: {Volume(3.0, 4.0, 5.0)}");
            Console.WriteLine($"Cylinder volume: {Volume(3.0, 7.0, true):F2}");

            Console.WriteLine();

            // --- Q5: Login with optional and named arguments ---
            Login("jola");
            Login("usman", "securepass");
            Login(username: "admin", password: "root99", isAdmin: true);

            Console.WriteLine();

            // --- Q6: GetStatistics with out ---
            int[] numbers = { 10, 20, 5, 40, 15 };
            GetStatistics(numbers, out int sum, out double average, out int min, out int max);
            Console.WriteLine($"Sum: {sum}");
            Console.WriteLine($"Average: {average}");
            Console.WriteLine($"Min: {min}");
            Console.WriteLine($"Max: {max}");

            Console.WriteLine();

            // --- Q7: Calculate with ref + params (Challenge) ---
            double result = 0;

            Calculate(ref result, "add", 10, 20, 30);
            Console.WriteLine($"Add result: {result}");

            Calculate(ref result, "multiply", 2, 3, 4);
            Console.WriteLine($"Multiply result: {result}");

            Calculate(ref result, "add", 5, 5);
            Console.WriteLine($"Add result: {result}");

            Console.WriteLine();

            // --- Q8: CalculateArea ---
            Console.WriteLine($"Area (4 x 5): {CalculateArea(4, 5)}");
            Console.WriteLine($"Area (7 x 3): {CalculateArea(7, 3)}");
            Console.WriteLine($"Area (10 x 2.5): {CalculateArea(10, 2.5)}");

            Console.WriteLine();

            // --- Q9: GetGrade ---
            Console.WriteLine($"Score 85: {GetGrade(85)}");
            Console.WriteLine($"Score 63: {GetGrade(63)}");
            Console.WriteLine($"Score 51: {GetGrade(51)}");
            Console.WriteLine($"Score 44: {GetGrade(44)}");
            Console.WriteLine($"Score 30: {GetGrade(30)}");

            Console.WriteLine();

            // --- Q10: IsPalindrome ---
            Console.WriteLine($"madam: {IsPalindrome("madam")}");
            Console.WriteLine($"racecar: {IsPalindrome("racecar")}");
            Console.WriteLine($"hello: {IsPalindrome("hello")}");
        }


        // Q1 — Overloaded Describe
        static void Describe(string name)
        {
            Console.WriteLine($"Name: {name}");
        }

        static void Describe(string name, int age)
        {
            Console.WriteLine($"Name: {name}, Age: {age}");
        }

        static void Describe(string name, int age, string city)
        {
            Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
        }


        // Q2 — FixScore using ref
        static void FixScore(ref int score)
        {
            if (score < 0)
                score = 0;
            else if (score > 100)
                score = 100;
        }


        // Q3 — FindHighest using params
        static int FindHighest(params int[] numbers)
        {
            int highest = numbers[0];
            foreach (var number in numbers)
            {
                if (number > highest)
                    highest = number;
            }
            return highest;
        }


        // Q4 — Overloaded Volume
        static double Volume(double side)
        {
            return side * side * side;
        }

        static double Volume(double l, double w, double h)
        {
            return l * w * h;
        }

        static double Volume(double radius, double height, bool isCylinder)
        {
            return Math.PI * radius * radius * height;
        }


        // Q5 — Login with optional and named arguments
        static void Login(string username, string password = "1234", bool isAdmin = false)
        {
            string message = $"Welcome, {username}!";
            if (isAdmin)
                message += " [ADMIN ACCESS]";
            Console.WriteLine(message);
        }


        // Q6 — GetStatistics using out
        static void GetStatistics(int[] numbers, out int sum, out double average, out int min, out int max)
        {
            sum = 0;
            min = numbers[0];
            max = numbers[0];

            foreach (var number in numbers)
            {
                sum += number;
                if (number < min) min = number;
                if (number > max) max = number;
            }

            average = (double)sum / numbers.Length;
        }


        // Q7 — Calculate using ref + params (Challenge)
        static void Calculate(ref double result, string operation, params double[] numbers)
        {
            if (operation == "add")
            {
                result = 0;
                foreach (var number in numbers)
                    result += number;
            }
            else if (operation == "multiply")
            {
                result = 1;
                foreach (var number in numbers)
                    result *= number;
            }
        }


        // Q8 — CalculateArea
        static double CalculateArea(double length, double width)
        {
            return length * width;
        }


        // Q9 — GetGrade
        static string GetGrade(int score)
        {
            if (score >= 70) return "A";
            else if (score >= 60) return "B";
            else if (score >= 50) return "C";
            else if (score >= 40) return "D";
            else return "F";
        }


        // Q10 — IsPalindrome
        static bool IsPalindrome(string word)
        {
            word = word.ToLower();
            for (int i = 0; i < word.Length / 2; i++)
            {
                if (word[i] != word[word.Length - 1 - i])
                    return false;
            }
            return true;
        }
    }
}
