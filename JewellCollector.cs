namespace JewellNS
{
    public class JewelCollector
    {
        public static void Main()
        {
            Console.WriteLine("Para sair do programa digite 'quit' ");
            bool running = true;
            do
            {
                Console.WriteLine("Enter the command: ");
                string command = Console.ReadLine()!;

                if (command.Equals("quit"))
                {
                    running = false;
                }
                else if (command.Equals("w"))
                {
                    Console.WriteLine("w");
                }
                else if (command.Equals("a"))
                {
                    Console.WriteLine("a");
                }
                else if (command.Equals("s"))
                {
                    Console.WriteLine("s");
                }
                else if (command.Equals("d"))
                {
                    Console.WriteLine("d");
                }
                else if (command.Equals("g"))
                {
                    Console.WriteLine("g");
                }
            } while (running);
        }
    }
}