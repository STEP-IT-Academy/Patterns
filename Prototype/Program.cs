using Prototype.GeometricFigures;
using System;
using System.Collections.Generic;

namespace Prototype
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape> ();

            Circle circle1 = new Circle { X = 10, Y = 20, Radius = 15 };
            shapes.Add(circle1);

            Circle circle2 = circle1.Clone() as Circle;
            shapes.Add(circle2);

            Rectangle rectangle = new Rectangle { Width = 10, Height = 20 };
            shapes.Add(rectangle);

            List<Shape> shapesCopies = new List<Shape>(shapes);
            shapesCopies.ForEach((x) => x.Clone());

            Console.ReadKey();
        }
    }
}
