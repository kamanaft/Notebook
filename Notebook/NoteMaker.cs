using System.Collections.Generic;
using Notebook.Objects;

namespace Notebook
{
    public class NoteMaker : XmlMaker
    {
        public NoteBook noteBook;

        public NoteMaker()
        {
            noteBook = new NoteBook();
            noteBook.notes = new List<Note>();
        }

        public void AddUpdateNote(string name, string text, int index = -1)
        {
            if (index < 0)
            {
                var note = new Note(name, text);
                noteBook.notes.Add(note);
            }
            else
            {
                noteBook.notes[index].NoteName = name;
                noteBook.notes[index].NoteText = text;
            }

            SaveXml(noteBook);
        }

        public void DeleteNote(int index)
        {
            noteBook.notes.RemoveAt(index);
            SaveXml(noteBook);
        }

        public bool ReadBook()
        {
            var returnedNotebook = ReadXml();
            if (returnedNotebook == null)
            {
                return false;
            }

            noteBook = returnedNotebook;
            return true;
        }
        
    }
}