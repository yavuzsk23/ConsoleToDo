using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<string> tasks = new List<string>();

        while (true)
        {
            
            Console.WriteLine("1. Add Task ");
            Console.WriteLine("2. Show Tasks ");
            Console.WriteLine("3. Exit ");
            Console.Write("choose ");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.Write("task ");
                tasks.Add(Console.ReadLine());
            }
            else if (choice == "2")
            {
                Console.WriteLine("tasks ");

                foreach (string task in tasks)
                {
                    Console.WriteLine("- " + task);
                }
            }
            else if (choice == "3")
            {
                break;
            }
        }
    }
}
