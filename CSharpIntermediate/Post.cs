using System;

namespace CSharpIntermediate
{
    class Post
    {
        public string Title { get; private set; }
        public string Description { get; private set; }
        public int Votes { get; private set; }
        public DateTime CreationDate { get; private set; }

        public Post(string title, string description)
        {
            this.Title = title;
            this.Description = description;
            this.CreationDate = DateTime.Now;
        }

        public bool UpVote()
        {
            this.Votes++;
            return true;
        }

        public bool DownVote()
        {
            this.Votes--;
            return true;
        }
    }
}
