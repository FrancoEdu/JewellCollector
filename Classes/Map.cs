namespace JewellNS;

public class Map
{
    private Object[,] arrayObj;
    private int linha;
    private int coluna;
    public Map(int width, int height)
    {
        this.linha = width;
        this.coluna = height;
        arrayObj = new Object[width, height];
    }
    public void setCell(int i, int j, Object obj)
    {
        if (obj is Jewell jewell)
        {
            arrayObj[i, j] = jewell;
        }
        else if (obj is Obstacle obstacle)
        {
            arrayObj[i, j] = obstacle;
        }
        else if (obj is Player player)
        {
            arrayObj[i, j] = player;
        }
    }
    public void removeCell(int i, int j)
    {
        arrayObj[i, j] = null;
    }
    public void PrintMap()
    {
        Console.Clear();

        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                if (arrayObj[i, j] is null)
                {
                    Console.Write(" -- ");
                }
                else if (arrayObj[i, j] is Jewell jewell)
                {
                    Console.Write(jewell.Name);
                }
                else if (arrayObj[i, j] is Obstacle obstacle)
                {
                    Console.Write(obstacle.obstacle);
                }
                else if (arrayObj[i, j] is Player player)
                {
                    Console.Write(player.Name);
                }
            }
            Console.WriteLine();
        }
    }
    public void FindPlayerPosition()
    {
        for (int i = 0; i < linha; i++)
        {
            for (int j = 0; j < coluna; j++)
            {
                if (arrayObj[i, j] is Player player)
                {
                    player.setLinhaPlayer(i);
                    player.setColunaPlayer(j);
                }
            }
        }
    }
}
