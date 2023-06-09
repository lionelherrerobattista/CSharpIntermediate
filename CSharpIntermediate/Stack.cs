using System;
using System.Collections;

namespace CSharpIntermediate
{
    public class Stack
    {
        //arrayList to store?

        private readonly ArrayList _stack;

        public Stack()
        {
            _stack = new ArrayList();
        }

        // three methods

        public void Push(object obj)
        {
            // stores the given obj on top
            // obj null case
            if (obj == null)
            {
                throw new InvalidOperationException();
            }

            _stack.Add(obj);
        }

        public object Pop()
        {
            object result;
            int count = _stack.Count;
            // removes the object on top
            // case empty stack
            if (count == 0)
                throw new InvalidOperationException();

            result = _stack[count - 1];

            _stack.RemoveAt(count - 1);

            return result;
        }

        public void Clear()
        {
            // removes all objects from stack
            _stack.Clear();
        }
    }
}
