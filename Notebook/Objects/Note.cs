using System.Xml.Serialization;

namespace Notebook.Objects
{
    public class Note
    {
        [XmlElement("NoteName")] 
        public string NoteName;

        [XmlElement("NoteText")] 
        public string NoteText;
        
        public Note()
        {
            
        }

        public Note(string name, string text)
        {
            NoteName = name;
            NoteText = text;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", NoteName, NoteText.Substring(0,NoteText.Length < 10 ? NoteText.Length : 15));
        }
    }
}