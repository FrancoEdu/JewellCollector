namespace JewellNS;
public class JewelCollector
{
    public static void Main(string[] args)
    {
        Map map = new Map(10, 10);
        Jewell jr = new Jewell("red", " JR ", 100);
        Jewell jg = new Jewell("green", " JG ", 50);
        Jewell jb = new Jewell("blue", " JB ", 10);
        Obstacle water = new Obstacle("water", " ## ");
        Obstacle tree = new Obstacle("tree", " $$ ");
        Player player = new Player(" ME ");
        map.setCell(0, 0, player);
        map.setCell(1, 9, jr);
        map.setCell(8, 8, jr);
        map.setCell(9, 1, jg);
        map.setCell(7, 6, jg);
        map.setCell(3, 4, jb);
        map.setCell(2, 1, jb);
        map.setCell(5, 0, water);
        map.setCell(5, 1, water);
        map.setCell(5, 2, water);
        map.setCell(5, 3, water);
        map.setCell(5, 4, water);
        map.setCell(5, 5, water);
        map.setCell(5, 6, water);
        map.setCell(5, 9, tree);
        map.setCell(3, 9, tree);
        map.setCell(8, 3, tree);
        map.setCell(2, 5, tree);
        map.setCell(1, 4, tree);
        map.PrintMap();
        map.FindPlayerPosition();
        Play(player, tree, water, jr, jb, jg, map);
    }

    public static void Play(Player player, Obstacle tree, Obstacle water, Jewell jr, Jewell jb, Jewell jg, Map map)
    {
        bool running = true;
        do
        {
            Console.WriteLine(player.toString());
            Console.WriteLine("Enter the command: ");
            string command = Console.ReadLine()!;

            if (command.Equals("quit"))
            {
                running = false;
            }
            else if (command.Equals("w"))
            {
                try
                {
                    map.FindPlayerPosition();
                    player.moveToTop(map);
                    map.PrintMap();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else if (command.Equals("a"))
            {
                try
                {
                    map.FindPlayerPosition();
                    player.moveToLeft(map);
                    map.PrintMap();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else if (command.Equals("s"))
            {
                try
                {
                    map.FindPlayerPosition();
                    player.moveToBottom(map);
                    map.PrintMap();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else if (command.Equals("d"))
            {
                try
                {
                    map.FindPlayerPosition();
                    player.moveToRight(map);
                    map.PrintMap();
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
            else if (command.Equals("g"))
            {
                try
                {
                    map.FindPlayerPosition();
                    player.captureJewell(map);
                    map.PrintMap();
                }
                catch
                {
                    Console.WriteLine("Não existe joia ao redor");
                }
            }
        } while (running);
    }
}