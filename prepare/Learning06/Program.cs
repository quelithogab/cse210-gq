using System;

class Program
{
    static void Main(string[] args)
    {
        List<Shape> shapes = new List<Shape>
        { 
            new Square("Red", 3), 
            new Rectangle("Blue", 4, 5), 
            new Circle("Green", 6) 
        }; 
        
        foreach (Shape shape in shapes) 
        { 
            Console.WriteLine($"The: {shape.GetColor()},  has an Area of: {shape.GetArea()}"); 
        }
    }
}