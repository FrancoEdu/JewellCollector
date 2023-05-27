namespace JewellNS;
public class Jewell
{
    public string Name;
    public string Color;
    public int Point;

    public Jewell(string color, int point, string name)
    {
        this.Color = color;
        this.Point = point;
        this.Name = name;
    }
    public string getName()
    {
        return this.Name;
    }
    public void setName(string name)
    {
        this.Name = name;
    }
    public string getColor()
    {

        return this.Color;
    }
    public void setColor(string color)
    {
        this.Color = color;
    }
    public int getPoint()
    {
        return this.Point;
    }
    public void setPoint(int point)
    {
        this.Point = point;
    }

    public string toString()
    {
        return $"Cor: {this.Color}, Point: {this.Point}, Name: {this.Name}";
    }
}
