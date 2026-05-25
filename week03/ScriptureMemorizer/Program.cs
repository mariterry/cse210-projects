using System;

class Program
{
    static void Main()
    {
        Reference ref1 = new Reference("John", 3, 16);
        Scripture scripture = new Scripture(ref1, "For God so loved the world");

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());

            if (scripture.AllHidden())
                break;

            Console.WriteLine("\nPress Enter to continue or type 'quit': ");
            string input = Console.ReadLine();

            if (input == "quit")
                break;

            scripture.HideRandomWords();
        }
    }
}