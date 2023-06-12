using System;

namespace CSharpIntermediate
{
    public class EmailNotifier : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video started processing. Email sent to the owner!");
        }
    }
}
