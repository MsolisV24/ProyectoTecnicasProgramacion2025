using System.Collections.Generic;
using ClassController.Abstractions;

namespace ClassController
{
    public class FileHandler<T> : IDataHandler<T>
    {
        public List<T> LoadData(string fileName)
        {
            return new List<T>();
        }

        public bool SaveData(List<T> data, string fileName)
        {
            return true;
        }
    }
}
