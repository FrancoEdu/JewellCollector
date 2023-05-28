namespace JewellNS;
public class Jewell
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Point { get; set; }

    public string toString()
    {
        return $"Cor: {this.Color}, Point: {this.Point}, Name: {this.Name}";
    }
}
