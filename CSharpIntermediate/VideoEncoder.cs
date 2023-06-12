using System;

namespace CSharpIntermediate
{
    public class VideoEncoder : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video is ready for encoding!");
        }
    }
}
