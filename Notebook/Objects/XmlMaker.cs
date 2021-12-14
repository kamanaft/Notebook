using System;
using System.IO;
using System.Xml.Serialization;

namespace Notebook.Objects
{
    public class XmlMaker
    {
        public string FilePath;

        public XmlMaker()
        {
            FilePath = $"{Environment.CurrentDirectory}\\NoteBook.xml";
        }

        // Load notes from file
        public NoteBook ReadXml()
        {
            if (!File.Exists(FilePath))
            {
                return null;
            }

            var noteBook = new NoteBook();

            try
            {
                XmlSerializer xmlDeserial = new XmlSerializer(noteBook.GetType());
                using (StreamReader reader = new StreamReader(FilePath))
                {
                    noteBook = (NoteBook)xmlDeserial.Deserialize(reader);
                }
            }
#pragma warning disable CS0168 // Переменная "e" объявлена, но ни разу не использована.
            catch (Exception e)
#pragma warning restore CS0168 // Переменная "e" объявлена, но ни разу не использована.
            {
                return null;
            }

            return noteBook;
        }
        
        // Save notes to file
        public bool SaveXml(NoteBook noteBook)
        {
            try
            {
                XmlSerializer xmlSerial = new XmlSerializer(noteBook.GetType());
                using(StreamWriter writer = new StreamWriter(FilePath))
                {
                    xmlSerial.Serialize(writer, noteBook);
                }
                return true;
            }
#pragma warning disable CS0168 // Переменная "e" объявлена, но ни разу не использована.
            catch (Exception e)
#pragma warning restore CS0168 // Переменная "e" объявлена, но ни разу не использована.
            {
                return false;
            }
        }


    }
}