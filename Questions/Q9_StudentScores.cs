using System.Collections;

namespace CSharpAssignment3.Questions;

public static class Q9_StudentScores
{
    public static void Run()
    {
        Console.WriteLine("Q9: Student Score Manager");

        SortedList scores = new SortedList();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add student score");
            Console.WriteLine("2. Search for a student");
            Console.WriteLine("3. Display all students");
            Console.WriteLine("0. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                if (scores.ContainsKey(name))
                {
                    Console.WriteLine(name + " already exists.");
                }
                else
                {
                    Console.Write("Enter score: ");
                    int score = int.Parse(Console.ReadLine());
                    scores.Add(name, score);
                    Console.WriteLine(name + " added with score " + score);
                }
            }
            else if (choice == "2")
            {
                Console.Write("Enter student name: ");
                string name = Console.ReadLine();

                if (scores.ContainsKey(name))
                {
                    Console.WriteLine(name + "'s score: " + scores[name]);
                }
                else
                {
                    Console.WriteLine("Student not found.");
                }
            }
            else if (choice == "3")
            {
                if (scores.Count == 0)
                {
                    Console.WriteLine("No students added yet.");
                }
                else
                {
                    Console.WriteLine("Students (sorted by name):");
                    foreach (DictionaryEntry entry in scores)
                    {
                        Console.WriteLine(entry.Key + " - " + entry.Value);
                    }
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
