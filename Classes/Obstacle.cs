namespace JewellNS;
public class Obstacle
{
    private string name;
    private string symbol;
    public Obstacle(string name, string symbol) { this.name = name; this.symbol = symbol; }
    public string getName() { return this.name; }
    public string getSymbol() { return this.symbol; }
    public string toString() { return $"Obstaculo : {this.name}"; }
}
