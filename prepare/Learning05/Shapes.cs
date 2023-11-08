using System.Formats.Asn1;
using System.Runtime.CompilerServices;

abstract class Shape
{
    private string _color;
    protected float _param1;
    protected float _param2;
    public Shape(string color, float param1, float param2=0f) {
        _color = color;
        _param1 = param1;
        _param2 = param2;
    }
    public abstract float CalculateArea();
    public string GetColor() {
        return _color;
    }
}

class Circle : Shape 
{
    public Circle(string color, float param1) : base(color, param1) {}
    public override float CalculateArea() {
        return _param1 * _param1 * 3.14159f; 
    }
}

class Square : Shape 
{

    public Square(string color, float sideLength) : base(color, sideLength) {
    }
    public override float CalculateArea() {
        return _param1 * _param1;
    }
}

class Rectangle : Shape 
{
    public Rectangle(string color, float param1, float param2) : base(color, param1, param2) {}
    public override float CalculateArea() {
        return _param1 * _param2;
    }
}