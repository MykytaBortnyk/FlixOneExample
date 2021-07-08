using System;

namespace FlixOne.InventoryManagementClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();
            GetCommand("?").RunCommand(out bool slouldQuit);
            while(!slouldQuit)
            {
                Console.WriteLine(" > ");
                var input = Console.ReadLine();
                var command = GetCommand(input);
                var wasSuccessful = command.RunCommand(out bool slouldQuit);

                if (!wasSuccessful)
                    Console.WriteLine("Enter ? to view options");
            }
            Console.WriteLine("CatalogService has completed.");
        }
    }
}
