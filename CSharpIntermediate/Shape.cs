using System;

namespace CSharpIntermediate
{
    public class Circle : Shape // encapsulate behavior
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a circle");
            //base.Draw(); // calls the parent
        }
    }

    public class Rectangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a rectangle");
        }
    }

    public class Triangle : Shape
    {
        public override void Draw()
        {
            Console.WriteLine("Draw a triangle");
        }
    }

    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        //public Position Position { get; set; }

        public virtual void Draw() // method overriding
        {

        }
    }
}
