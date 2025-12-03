namespace ClassController
{
    /// <summary>
    /// implements a CSV data loader.
    /// </summary>
    /// <seealso cref="ClassController.IDataLoader" />
    public class DataLoaderCsv : IDataLoader
    {
        /// <summary>
        /// Loads the CSV.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="path">The path.</param>
        /// <returns></returns>
        public List<T> LoadCsv<T>(string path)
        {
            var list = new List<T>();

            if (!File.Exists(path))
                return list;

            var lines = File.ReadAllLines(path);

            foreach (var line in lines)
            {
                if (string.IsNullOrWhiteSpace(line))
                    continue;

                if (line.Contains("..."))
                    continue;

                var parts = line.Split(',');

                if (typeof(T) == typeof(ClassModels.Customer) && parts.Length > 4)
                    parts = parts.Take(4).ToArray();

                var obj = Activator.CreateInstance<T>();
                var props = typeof(T).GetProperties();

                for (int c = 0; c < props.Length && c < parts.Length; c++)
                {
                    var prop = props[c];

                    if (string.IsNullOrWhiteSpace(parts[c]))
                        continue;

                    try
                    {
                        object? value = Convert.ChangeType(parts[c], prop.PropertyType);
                        prop.SetValue(obj, value);
                    }
                    catch
                    {
                        continue;
                    }
                }

                list.Add(obj);
            }

            return list;
        }
    }
}


