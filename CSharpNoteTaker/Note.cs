namespace CSharpNoteTaker
{
    public class Note
    {
        private int _id;
        public string Title { get; set; }
        public string DateCreated { get; }
        private string Text { get; set; }

        public Note(int id, string title, string dateCreated, string text)
        {
            _id = id;
            Title = title;
            DateCreated = dateCreated;
            Text = text;
        }
    }
}