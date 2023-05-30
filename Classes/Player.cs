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

    public void moveToLeft()
    {
        if (this.getLinhaPlayer() > 0)
        {

        }
    }
    public void moveToRight()
    {

    }
    public void moveToTop()
    {

    }
    public void moveToBottom()
    {

    }
}