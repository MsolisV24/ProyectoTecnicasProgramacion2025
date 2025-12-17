using System.Collections.Generic;

namespace ClassController.Abstractions
{
    public interface IDataHandler<T>
    {
        List<T> LoadData(string fileName);
        bool SaveData(List<T> data, string fileName);
    }
}
