using System;
using System.Collections.Generic;

namespace CSharpIntermediate
{
    public class Canvas
    {
        public void DrawShapes(List<Shape> shapes)
        {
            foreach (var shape in shapes)
            {
                shape.Draw(); // will call the override method of each shape
                // we can add more shapes
                // without modifying this method
            }
        }
    }
}
