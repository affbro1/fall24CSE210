using System;

public abstract class Shape{

    public string _color { get; set; }

    public Shape(string color)
    {
        _color = color;
    }

    public string GetColor()
    {
        return _color;
    }

    public abstract double GetArea();
}
