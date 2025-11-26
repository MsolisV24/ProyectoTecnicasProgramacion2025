using ClassModels;

namespace ClassController.Abstractions
{
    /// <summary>
    /// Interface in charge of defining user handler operations.
    /// </summary>
    public class UserHandler
    {
        private readonly IDataHandler<Customer> dataHandler;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserHandler"/> class.
        /// </summary>
        /// <param name="dataHandler">The data handler.</param>
        public UserHandler(IDataHandler<Customer> dataHandler)
        {
            this.dataHandler = dataHandler;
        }

        /// <summary>
        /// Gets or sets the costumers.
        /// </summary>
        /// <value>
        /// The costumers.
        /// </value>
        public List<Customer> Custumers { get; set; } = new List<Customer>();

        /// <summary>
        /// Saves the users.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>true if succeded otherwise false.</returns>
        public bool SaveUsers(string fileName)
        {
            return dataHandler.SaveData(Custumers, fileName);
        }

        /// <summary>
        /// Loads the users.
        /// </summary>
        /// <param name="fileName">Name of the file.</param>
        /// <returns>true if succeded otherwise false.</returns>
        public bool LoadUsers(string fileName)
        {
            this.Custumers = dataHandler.LoadData(fileName);
            if (this.Custumers != null && this.Custumers.Count > 0)
            {
                return true;
            }

            return false;
        }
    }
}
