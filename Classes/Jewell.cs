namespace JewellNS;
public class Jewell
{
    public string Name { get; set; }
    public string Color { get; set; }
    public int Point { get; set; }

    public int calculatePoint(Jewell jewell)
    {
        int resultado = 0;
        if (jewell.Color == "red")
        {
            resultado = jewell.Point;
            return resultado;
        }
        else if (jewell.Color == "green")
        {
            resultado = jewell.Point;
            return resultado;
        }
        else
        {
            resultado = jewell.Point;
            return resultado;
        }
    }

    public string toString()
    {
        return $"Cor: {this.Color}, Point: {this.Point}, Name: {this.Name}";
    }
}
