using ClassController.Abstractions;
using ClassModels;

namespace ClassController
{
    public class UserHandler
    {
        private readonly IDataHandler<Customer> _dataHandler;
        public List<Customer> Custumers { get; set; }

        public UserHandler(IDataHandler<Customer> dataHandler)
        {
            _dataHandler = dataHandler;
            Custumers = _dataHandler.LoadData("");
        }

        public bool LoadUsers(string fileName)
        {
            Custumers = _dataHandler.LoadData(fileName);
            return Custumers != null && Custumers.Count > 0;
        }
    }
}
