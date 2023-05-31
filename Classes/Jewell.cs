namespace JewellNS;
public class Jewell
{
    private string name;
    private string color;
    private int point;

    public Jewell(string color, string name, int point)
    {
        this.name = name;
        this.color = color;
        this.point = point;
    }
    public string getName() { return this.name; }
    public string getColor() { return this.color; }
    public int getPoint() { return this.point; }

    public string toString()
    {
        return $"Cor: {this.color}, Point: {this.point}, Name: {this.name}";
    }
}
