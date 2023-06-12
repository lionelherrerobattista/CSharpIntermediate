using System;

namespace CSharpIntermediate
{
    public class VideoUploader : IActivity
    {
        public void Execute()
        {
            Console.WriteLine("Video uploaded to cloud storage!");
        }
    }
}
