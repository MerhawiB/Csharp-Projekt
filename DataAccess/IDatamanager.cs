using Model;
using System.Collections.Generic;

// Custom made interface that the class FileContext uses

namespace DataAccess
{
    internal interface IDatamanager
    {
        IEnumerable<T> Load<T>(string fileName);
        void Save<T>(List<T> fileToSave, string fileName);
    }
}