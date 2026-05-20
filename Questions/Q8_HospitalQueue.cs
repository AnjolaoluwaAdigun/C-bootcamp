using System.Collections;

namespace CSharpAssignment3.Questions;

public static class Q8_HospitalQueue
{
    public static void Run()
    {
        Console.WriteLine("Q8: Hospital Patient Queue");

        Queue patientQueue = new Queue();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add patient");
            Console.WriteLine("2. Attend to next patient");
            Console.WriteLine("3. View next patient");
            Console.WriteLine("4. View all patients");
            Console.WriteLine("0. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter patient name: ");
                string name = Console.ReadLine();
                patientQueue.Enqueue(name);
                Console.WriteLine(name + " added to the queue.");
            }
            else if (choice == "2")
            {
                if (patientQueue.Count == 0)
                {
                    Console.WriteLine("No patients in the queue.");
                }
                else
                {
                    string patient = patientQueue.Dequeue().ToString();
                    Console.WriteLine("Now attending to: " + patient);
                    Console.WriteLine("Patients remaining: " + patientQueue.Count);
                }
            }
            else if (choice == "3")
            {
                if (patientQueue.Count == 0)
                {
                    Console.WriteLine("No patients in the queue.");
                }
                else
                {
                    Console.WriteLine("Next patient: " + patientQueue.Peek());
                }
            }
            else if (choice == "4")
            {
                if (patientQueue.Count == 0)
                {
                    Console.WriteLine("The queue is empty.");
                }
                else
                {
                    Console.WriteLine("Patients in queue:");
                    int position = 1;
                    foreach (var p in patientQueue)
                    {
                        Console.WriteLine(position + ". " + p);
                        position++;
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
