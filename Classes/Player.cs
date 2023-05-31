namespace JewellNS;
public class Player
{
    private int bagValue = 0;
    private Object[] bagItems = new Object[] { };
    private string name;
    private int linhaPlayer;
    private int colunaPlayer;
    public Player(string name)
    {
        this.name = name;
    }
    public string getName() { return this.name; }
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
        return $"Bag total items: {this.bagItems.Length} | Bag total value: {this.bagValue}";
    }

    public void moveToLeft(Map map)
    {
        if (this.getColunaPlayer() > 0)
        {
            if (existsJewellOrObstacle(getLinhaPlayer(), getColunaPlayer() - 1, map) == false)
            {
                map.removeCell(getLinhaPlayer(), getColunaPlayer());
                map.setCell(getLinhaPlayer(), getColunaPlayer() - 1, this);
            }
        }
    }
    public void moveToRight(Map map)
    {
        if (this.getColunaPlayer() < map.getNumberOfColunas())
        {
            if (existsJewellOrObstacle(getLinhaPlayer(), getColunaPlayer() + 1, map) == false)
            {
                map.removeCell(getLinhaPlayer(), getColunaPlayer());
                map.setCell(getLinhaPlayer(), getColunaPlayer() + 1, this);
            }
        }
    }
    public void moveToTop(Map map)
    {
        if (this.getLinhaPlayer() > 0)
        {
            if (existsJewellOrObstacle(getLinhaPlayer() - 1, getColunaPlayer(), map) == false)
            {
                map.removeCell(getLinhaPlayer(), getColunaPlayer());
                map.setCell(getLinhaPlayer() - 1, getColunaPlayer(), this);
            }
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
        if (posicao is Jewell jewell || posicao is Obstacle obstacle)
        {
            return true;
        }
        return false;
    }

    public void captureJewell(Map map)
    {
        map.FindPlayerPosition();
        int linhaDoJogador = getLinhaPlayer();
        int colunaDoJoagdor = getColunaPlayer();

        if (map.getObject(linhaDoJogador + 1, colunaDoJoagdor) is Jewell)
        {
            updateBag(map.getObject(linhaDoJogador + 1, colunaDoJoagdor));
            map.removeCell(linhaDoJogador + 1, colunaDoJoagdor);
        }
        else if (map.getObject(linhaDoJogador - 1, colunaDoJoagdor) is Jewell)
        {
            updateBag(map.getObject(linhaDoJogador - 1, colunaDoJoagdor));
            map.removeCell(linhaDoJogador - 1, colunaDoJoagdor);
        }
        else if (map.getObject(linhaDoJogador, colunaDoJoagdor + 1) is Jewell)
        {
            updateBag(map.getObject(linhaDoJogador, colunaDoJoagdor + 1));
            map.removeCell(linhaDoJogador, colunaDoJoagdor + 1);
        }
        else if (map.getObject(linhaDoJogador, colunaDoJoagdor - 1) is Jewell)
        {
            updateBag(map.getObject(linhaDoJogador, colunaDoJoagdor - 1));
            map.removeCell(linhaDoJogador, colunaDoJoagdor - 1);
        }
    }

    public void updateBag(Object objeto)
    {
        if (objeto is Jewell jewell)
        {
            this.bagValue = this.bagValue + jewell.getPoint();
            Array.Resize(ref bagItems, bagItems.Length + 1);
            bagItems[bagItems.Length - 1] = jewell;
        }
    }
}