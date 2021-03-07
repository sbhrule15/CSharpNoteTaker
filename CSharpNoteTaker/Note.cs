using System;

namespace CSharpNoteTaker
{
    public class Note
    {
        private readonly Random _random = new Random();
        private int _id;
        public string Title { get; }
        public DateTime DateCreated { get; }
        public string Text { get; }

        public Note(string title, string text)
        {
            _id = _random.Next();
            Title = title;
            DateCreated = DateTime.Now;
            Text = text;
        }
    }
}