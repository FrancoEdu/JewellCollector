namespace JewellNS;
public class Player
{
    private int bag = 5;
    public string Name { get; set; }
    private int linhaPlayer;
    private int colunaPlayer;
    public int getLinhaPlayer() { return this.linhaPlayer; }
    public int getColunaPlayer() { return this.colunaPlayer; }
    public void setLinhaPlayer(int linha)
    {
        this.linhaPlayer = linha;
    }
    public void setColunaPlayer(int coluna)
    {
        this.colunaPlayer = coluna;
    }

    public string toString()
    {
        return $"Name {this.Name}";
    }

    public void moveToLeft(Map map)
    {
        if (this.getColunaPlayer() > 0)
        {
            map.removeCell(getLinhaPlayer(), getColunaPlayer());
            map.setCell(getLinhaPlayer(), getColunaPlayer() - 1, this);
        }
    }
    public void moveToRight(Map map)
    {
        if (this.getColunaPlayer() < map.getNumberOfColunas())
        {
            map.removeCell(getLinhaPlayer(), getColunaPlayer());
            map.setCell(getLinhaPlayer(), getColunaPlayer() + 1, this);
        }
    }
    public void moveToTop(Map map)
    {
        if (this.getLinhaPlayer() > 0)
        {
            map.removeCell(getLinhaPlayer(), getColunaPlayer());
            map.setCell(getLinhaPlayer() - 1, getColunaPlayer(), this);
        }
    }
    public void moveToBottom(Map map)
    {
        if (this.getLinhaPlayer() < map.getNumberOfLinhas())
        {
            if (existsJewellOrObstacle(getLinhaPlayer() + 1, getColunaPlayer(), map) == false)
            {
                map.removeCell(getLinhaPlayer(), getColunaPlayer());
                map.setCell(getLinhaPlayer() + 1, getColunaPlayer(), this);
            }
        }
    }
    public bool existsJewellOrObstacle(int proximaLinha, int proximaColuna, Map map)
    {
        Object posicao = map.getObject(proximaLinha, proximaColuna);
        if (posicao is Obstacle obstacle || posicao is Jewell jewell)
        {
            return true;
        }
        return false;
    }
}