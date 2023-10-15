using System;

public class Fraction
{
    // Attributes
    private int _top;
    private int _bottom;

    // Constructors
    public Fraction()
    {
        _top = 1;
        _bottom =1;
    }
    public Fraction(int topNumber)
    {
        _top = topNumber;
        _bottom = 1;
    }
    public Fraction(int top, int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    // // Getters and Setters
    // public int GetTop()
    // {
    //      Console.WriteLine(_top);
    //     return _top;
    // }
    // public void SetTop(int newTop)
    // {
    //     _top = newTop;
    // }

    // public int GetBottom()
    // {
    //     Console.WriteLine(_bottom);
    //     return _bottom;
    // }
    // public void SetBottom(int newBottom)
    // {
    //     _bottom = newBottom;
    // }

    //Get fraction string
    public string GetFractionString()
    {
        string fractionString = $"{_top}/{_bottom}";
        return fractionString;
    }

    public double GetDecimalValue()
    {
        double decimalValue = Convert.ToDouble(_top) / Convert.ToDouble(_bottom);
        return decimalValue;
    }


}