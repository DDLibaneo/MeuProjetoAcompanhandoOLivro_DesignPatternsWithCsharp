using System;

namespace FlixOne.InventoryManagementClient
{
    class Program
    {
        static void Main(string[] args)
        {
            Greeting();

            // GetCommand("?").RunCommand(out bool shouldQuit);

            //while(!shouldQuit)
            //{
                // handle the commands  

                //Console.WriteLine(" > ");

                //var input = Console.ReadLine();

                //var command = GetCommand(input);

                //var wasSuccessful = command.RunCommand(out shouldQuit);

                //if (!wasSuccessful)
                //{
                //    Console.WriteLine("Enter ? to view options.");
                //}
            //}

            Console.WriteLine("CatalogService has completed.");
        }

        private static void Greeting()
        {
            throw new NotImplementedException();
        }
    }
}
