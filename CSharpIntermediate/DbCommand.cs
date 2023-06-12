using System;

namespace CSharpIntermediate
{
    public class DbCommand : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video's status changed to 'Processing'.");
        }
    }
}
