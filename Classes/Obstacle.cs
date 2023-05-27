namespace JewellNS;
public class Obstacle : Cell
{
    public string obstacle;
    public Obstacle(string type)
    {
        this.obstacle = type;
    }
    public void setObstacle(string obstacle)
    {
        this.obstacle = obstacle;
    }
    public string getObstacle()
    {
        return this.obstacle;
    }

    public void Draw(string type)
    {
        Console.BackgroundColor = ConsoleColor.Black;
        Console.BackgroundColor = ConsoleColor.Yellow;

        if (type == "tree")
        {
            Console.Write("##");
        }
        else
        {
            Console.Write("$$");
        }
    }
}
