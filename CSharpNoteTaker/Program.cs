using System;
using System.Collections.Generic;

namespace CSharpNoteTaker
{
    class Program
    {
        // menu prompts
        private static string startMessage = "---------------C Sharp Note Taker-----------------\n" +
                              "Welcome to the C Sharp Note Taker.";
        private static string mainMenu = "Please choose from the following options:\n" +
                          "\t1. Create a note\n" +
                          "\t2. See all notes\n" +
                          "\tQ. Quit Application";

        private static string goodbye = "Thank you for using the note taker. Goodbye!";
        private static string invalidChoice = "That was an invalid choice. Please try again with a valid meanu option.";
        
        // menu headers
        private static string createNoteMenuHeader = "----------------Create A Note------------------";
        private static string seeNotesMenuHeader = "----------------See All Notes------------------";
        
        // create note prompts
        private static string enterTitleMessage = "Please give your note a title:\n";
        private static string enterNoteMessage = "Enter your note:\n";
        private static string noteEntrySuccess = "Your note has been successfully entered";
        private static string noteEntryFailed = "Your note failed to be entered. Please try again.";
        
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
                    Console.WriteLine("This option is in development.");
                }
                else if (menuChoice == "Q")
                {
                    Console.WriteLine(goodbye);
                    break;
                }
                else
                {
                    Console.WriteLine();
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
    }
}