using System;
using System.Formats.Asn1;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        var circle = new Circle("red", 3f);
        var square = new Square("orange", 2f);
        var rectangle = new Rectangle("blue", 2f, 3f);
        shapes.Add(circle);
        shapes.Add(square);
        shapes.Add(rectangle);

        System.Console.WriteLine();
        foreach (Shape item in shapes) { 
            float area = item.CalculateArea();
            string color = item.GetColor();
            System.Console.WriteLine($"Area of {color} {item}: {area}");
        }
        System.Console.WriteLine();
    }
}

