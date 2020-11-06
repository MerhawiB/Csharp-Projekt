
using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DataAccess
{
    //A generic class for saving and loading data in the form of XML-Files.
    internal class FileContext : IDatamanager  
    {
        public void Save<T>(List<T> filesToSave, string fileName)
        {
            XmlSerializer xmlSeralizer = new XmlSerializer(filesToSave.GetType());
            using (FileStream outFile = new FileStream($"{fileName}.xml", FileMode.Create, FileAccess.Write))
            {
                xmlSeralizer.Serialize(outFile, filesToSave);
            }
        }
        public IEnumerable<T> Load<T>(string fileName)
        {
            IEnumerable<T> output = null;
            XmlSerializer xmlSeralizer = new XmlSerializer(typeof(List<T>));
            if (File.Exists($"{fileName}.xml")) 
            {           
                using (FileStream inFile = new FileStream($"{fileName}.xml", FileMode.Open, FileAccess.Read))
                {
                     output = (IEnumerable<T>)xmlSeralizer.Deserialize(inFile);
                }
            }            
            return output;
        }
    }
}
