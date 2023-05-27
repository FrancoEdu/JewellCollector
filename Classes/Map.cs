namespace JewellNS;

public class Map
{
    private Cell[,] cells;

    public Map(int width, int height)
    {
        cells = new Cell[width, height];
    }

    public void setCell(int i, int j, Cell obj)
    {
        cells[i, j] = obj;
    }

    public void PrintMap()
    {
        Console.Clear();

        for (int i = 0; i < cells.GetLength(0); i++)
        {
            for (int j = 0; j < cells.GetLength(1); j++)
            {
                Console.Write(" -- ");
            }
            Console.WriteLine();
        }
    }
}
