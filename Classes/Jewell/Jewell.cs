namespace JewellNS;
public class Jewell
{
    public Jewell(String color, int point, string name)
    {
        this.Color = color;
        this.Point = point;
        this.Name = name;
    }
    public string Color { get; set; }
    public string Name { get; set; }
    public int Point { get; set; }

    public string toString()
    {
        return $"Cor: {this.Color}, Point: {this.Point}, Name: {this.Name}";
    }
}
