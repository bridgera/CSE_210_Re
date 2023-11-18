public abstract class Shape
{
    private string _color;

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }
    public abstract double GetArea();
    
    public void DisplayShtuff()
    {
        Console.WriteLine($"The {GetColor()} shape has an area of {GetArea()}.");
    }

}