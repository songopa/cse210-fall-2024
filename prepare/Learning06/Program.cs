using System;

class Program
{
    static void Main(string[] args)
    {
        Square s1 = new Square(3.5);
        s1.SetColor("Red");
        Console.WriteLine($"\nColor: {s1.GetColor()} \nArea: {s1.GetArea()}");

        Square s2 = new Square(7);
        s2.SetColor("Brown");

        Rectangle r1 = new Rectangle(3, 13);
        r1.SetColor("Blue");

        Circle c1 = new Circle(10);
        c1.SetColor("White");

        List<Shape> shapes = new List<Shape>();
        shapes.Add(s2);
        shapes.Add(r1);
        shapes.Add(c1);

        foreach (Shape shape in shapes)
        {
            Console.WriteLine($"\nColor: {shape.GetColor()} \nArea: {shape.GetArea()}");
        }


    }
}