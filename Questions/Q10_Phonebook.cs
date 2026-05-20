using System.Collections;

namespace CSharpAssignment3.Questions;

public static class Q10_Phonebook
{
    public static void Run()
    {
        Console.WriteLine("Q10: Phonebook App");

        Hashtable phonebook = new Hashtable();
        bool running = true;

        while (running)
        {
            Console.WriteLine();
            Console.WriteLine("1. Add contact");
            Console.WriteLine("2. Search contact");
            Console.WriteLine("3. Update contact");
            Console.WriteLine("4. Delete contact");
            Console.WriteLine("5. Display all contacts");
            Console.WriteLine("0. Exit");
            Console.Write("Choose: ");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("Enter name: ");
                string name = Console.ReadLine();

                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine(name + " already exists. Use option 3 to update.");
                }
                else
                {
                    Console.Write("Enter phone number: ");
                    string number = Console.ReadLine();
                    phonebook.Add(name, number);
                    Console.WriteLine("Contact added.");
                }
            }
            else if (choice == "2")
            {
                Console.Write("Enter name to search: ");
                string name = Console.ReadLine();

                if (phonebook.ContainsKey(name))
                {
                    Console.WriteLine(name + ": " + phonebook[name]);
                }
                else
                {
                    Console.WriteLine("Contact not found.");
                }
            }
            else if (choice == "3")
            {
                Console.Write("Enter name to update: ");
                string name = Console.ReadLine();

                if (phonebook.ContainsKey(name))
                {
                    Console.Write("Enter new number: ");
                    string number = Console.ReadLine();
                    phonebook[name] = number;
                    Console.WriteLine("Contact updated.");
                }
                else
                {
                    Console.WriteLine("Contact not found.");
                }
            }
            else if (choice == "4")
            {
                Console.Write("Enter name to delete: ");
                string name = Console.ReadLine();

                if (phonebook.ContainsKey(name))
                {
                    phonebook.Remove(name);
                    Console.WriteLine("Contact deleted.");
                }
                else
                {
                    Console.WriteLine("Contact not found.");
                }
            }
            else if (choice == "5")
            {
                if (phonebook.Count == 0)
                {
                    Console.WriteLine("Phonebook is empty.");
                }
                else
                {
                    Console.WriteLine("All contacts:");
                    foreach (DictionaryEntry entry in phonebook)
                    {
                        Console.WriteLine(entry.Key + ": " + entry.Value);
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
