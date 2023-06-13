using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpIntermediate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var stack = new Stack();

            for(var i = 0; i < 3; i++)
            {
                stack.Push(i + 1);
            }

            //stack.Clear();

            for (var i = 0; i < 3; i++)
            {
                Console.WriteLine(stack.Pop());
            }

            // output should be 
            // 3
            // 2
            // 1
        }
    }
}
