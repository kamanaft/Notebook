using System.Collections.Generic;
using System.Xml.Serialization;

namespace Notebook.Objects
{
    [XmlRoot]
    [XmlInclude(typeof(Note))]
    public class NoteBook
    {
        [XmlAttribute("FileName")] 
        public string FileName = "NoteBook";

        [XmlArray("NoteArray")] 
        [XmlArrayItem("Note")]
        public List<Note> notes;

        public NoteBook()
        {
            
        }
    }
}