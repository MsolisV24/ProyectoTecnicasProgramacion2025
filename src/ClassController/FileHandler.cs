namespace ClassController
{
    using System.Collections.Generic;
    using ClassController.Abstractions;


    /// <summary>
    /// Implementation of <see cref="IDataHandler{T}"/> to handle file operations.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class FileHandler<T> : IDataHandler<T>
    {
        /// <summary>
        /// Loads the data.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>
        /// the list of data loaded.
        /// </returns>
        public List<T> LoadData(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                throw new ArgumentException("File name cannot be null or empty.", nameof(fileName));
            }
            else if (!File.Exists(fileName))
            {
                throw new FileNotFoundException("The specified file was not found.", fileName);
            }

            var result = new List<T>();

            var lines = File.ReadAllLines(fileName);

            foreach (var line in lines)
            {
                var properties = line.Split(',');
                var obj = (T)Activator.CreateInstance(typeof(T), properties)!;
                result.Add(obj);
            }

            return result;
        }

        /// <summary>
        /// Saves the data.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <returns>
        /// true if data is saved successfully; otherwise, false.
        /// </returns>
        public bool SaveData(List<T> data, string fileName)
        {
            if (data == null && data!.Count > 0)
            {
                // throw new ArgumentException("La lista de elementos no debe estar vacia");
                return false;
            }
            else if (string.IsNullOrEmpty(fileName))
            {
                // throw new ArgumentException("El nombre del archivo no puede ser nulo o vacio", nameof(fileName));
                return false;
            }
            else if (File.Exists(fileName))
            {
                File.Delete(fileName);
            }
            else if (!Directory.Exists(Path.GetDirectoryName(fileName)))
            {
                // throw new DirectoryNotFoundException("El directorio especificado no existe.");
                return false;
            }

            var file = File.Create(fileName);

            var writer = new StreamWriter(file);
            foreach (var element in data)
            {
                writer.WriteLine(element!.ToString());
            }

            return true;
        }
    }
}
