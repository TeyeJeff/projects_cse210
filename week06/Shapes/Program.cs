using System;
using System.Drawing;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>();
        Square s1 = new Square("blue", 15);
        shapes.Add(s1);

        Rectangle s2 = new Rectangle("Black", 9, 5);
        shapes.Add(s2);


        Circle s3 = new Circle("Pink", 3);
        shapes.Add(s3);

        foreach (Shape s in shapes)
        {
            string color = s.GetColor();

            double area = s.GetArea();

            Console.WriteLine($"{color} shape has an area of {area}");
        }
    }
}