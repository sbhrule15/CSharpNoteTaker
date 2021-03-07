using System;

namespace CSharpNoteTaker
{
    public class Note
    {
        private readonly Random _random = new Random();
        public int Id { get; private set;  }
        public string Title { get; private set;}
        public DateTime DateCreated { get; private set;}
        public string Text { get; private set;}

        public Note(string title, string text)
        {
            Id = _random.Next();
            Title = title;
            DateCreated = DateTime.Now;
            Text = text;
        }
        
    }
}