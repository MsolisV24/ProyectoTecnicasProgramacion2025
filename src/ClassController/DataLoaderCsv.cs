using System.Reflection;

namespace ClassController
{
    public class DataLoaderCsv : IDataLoader
    {
        public List<T> LoadCsv<T>(string path)
        {
            var list = new List<T>();

            if (!File.Exists(path))
                return list;

            var lines = File.ReadAllLines(path);
            if (lines.Length <= 1)
                return list;

            var headers = lines[0].Split(',');

            for (int i = 1; i < lines.Length; i++)
            {
                var parts = lines[i].Split(',');

                var obj = Activator.CreateInstance<T>();
                var props = typeof(T).GetProperties();

                for (int c = 0; c < parts.Length && c < props.Length; c++)
                {
                    var prop = props[c];
                    object? value = Convert.ChangeType(parts[c], prop.PropertyType);
                    prop.SetValue(obj, value);
                }

                list.Add(obj);
            }

            return list;
        }
    }
}

