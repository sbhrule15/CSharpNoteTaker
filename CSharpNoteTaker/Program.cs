using System;
using System.Collections.Generic;

namespace CSharpNoteTaker
{
    class Program
    {
        // menu prompts
        private static string startMessage = "\n---------------C Sharp Note Taker-----------------\n" +
                              "Welcome to the C Sharp Note Taker.";
        private static string mainMenu = "\n---------------------Main Menu---------------\n\n" + 
                                         "Please choose from the following options:\n" + 
                                         "\t1. Create a note\n" + 
                                         "\t2. See all notes\n" + 
                                         "\tQ. Quit Application";

        private static string goodbye = "\nThank you for using the note taker. Goodbye!";
        private static string invalidChoice = "\nThat was an invalid choice. Please try again with a valid menu option.\n\n";

        private static string inDev =
            "\nThis area of the application is in development. Please choose another option.\n\n";
        
        // menu headers
        private static string createNoteMenuHeader = "----------------Create A Note------------------";
        private static string seeNotesMenuHeader = "----------------See All Notes------------------";
        
        // create note prompts
        private static string enterTitleMessage = "\nPlease give your note a title:";
        private static string enterNoteMessage = "\nEnter your note:";
        private static string noteEntrySuccess = "\nYour note has been successfully entered\n";
        private static string noteEntryFailed = "\nYour note failed to be entered. Please try again.\n";
        
        static void Main(string[] args)
        {
            List<Note> noteList = new List<Note>();
            Console.WriteLine(startMessage);

            while (true)
            {
                Console.WriteLine(mainMenu);
                string menuChoice = Console.ReadLine();

                if (menuChoice == "1")
                {
                    noteList = CreateNote(noteList);
                }
                else if (menuChoice == "2")
                {
                    SeeNotes(noteList);
                }
                else if (menuChoice == "Q")
                {
                    Console.WriteLine(goodbye);
                    break;
                }
                else
                {
                    Console.WriteLine(invalidChoice);
                }
            }
        }

        public static List<Note> CreateNote(List<Note> noteList)
        {
            Console.WriteLine(createNoteMenuHeader);
            
            // Create title
            Console.WriteLine(enterTitleMessage);
            string noteTitle = Console.ReadLine();
            
            // create message
            Console.WriteLine(enterNoteMessage);
            string noteText = Console.ReadLine();
            
            // create note and add to list
            try
            {
                noteList.Add(new Note(noteTitle, noteText));
                Console.WriteLine(noteEntrySuccess);
                return noteList;
            }
            catch
            {
                Console.WriteLine(noteEntryFailed);
                return noteList;
            }
        }

        public static void SeeNotes(List<Note> noteList)
        {
            Console.WriteLine(seeNotesMenuHeader);
            
            if (noteList.Count == 0)
            {
                Console.WriteLine("\nThere are no notes to display.\n");
            }
            else
            {
                foreach (var note in noteList)
                {
                    Console.WriteLine("\nTitle: " + note.Title);
                    Console.WriteLine("Created: " + note.DateCreated);
                    Console.WriteLine("Note: " + note.Text);
                }
            }
            
        }
    }
}