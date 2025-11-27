namespace ClassController
{
    public interface IDataLoader
    {
        List<T> LoadCsv<T>(string path);
    }
}


