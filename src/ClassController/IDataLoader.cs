namespace ClassController
{
    /// <summary>
    /// implementation of data loader for loading data from various sources
    /// </summary>
    public interface IDataLoader
    {
        List<T> LoadCsv<T>(string path);
    }
}


