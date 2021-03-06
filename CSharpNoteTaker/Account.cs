using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharpNoteTaker
{
    public class Account
    {
        private readonly Random _random = new Random();
        public string Username { get; }
        private string _password;
        public int ID { get; }
        private List<Note> _notes;

        public Account(string username, string password)
        {
            ID = _random.Next();
            Username = username;
            _password = password;
            _notes = new List<Note>();
        }

        public bool CheckPassword(string password)
        {
            return password == _password;
        }

        public bool AddNote(Note newNote)
        {
            try
            {
                _notes.Add(newNote);
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}