namespace JewellNS;
public class Obstacle
{
    public string obstacle;
    public Obstacle(string type)
    {
        this.obstacle = type;
    }
    public void setObstacle(string obstacle)
    {
        this.obstacle = obstacle;
    }
    public string getObstacle()
    {
        return this.obstacle;
    }
}
