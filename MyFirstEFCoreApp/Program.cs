// See https://aka.ms/new-console-template for more information
using MyFirstEFCoreApp;

namespace MyFirstEfCoreApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(
                "Commands: l (list), u (change url), r (resetDb) and e (exit) - add -l to first two for logs");
            do
            {
                Console.Write("> ");
                var command = Console.ReadLine();
                switch (command)
                {
                    case "l":
                        Commands.ListAll();
                        break;
                    default:
                        Console.WriteLine("Unknown command.");
                        break;
                }
            } while (true);
        }
    }
}

   
