using System;

class Program
{
    static void Main(string[] args)
    {
        Square square = new Square("Green", 5);
        square.DisplayShtuff();

        Rectangle rectangle = new Rectangle("Yellow", 3, 134);
        rectangle.DisplayShtuff();

        Circle circle = new Circle("Red", 8);
        circle.DisplayShtuff();


    }
}