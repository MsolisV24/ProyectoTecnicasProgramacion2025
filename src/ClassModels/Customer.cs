namespace ClassModels
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public string Username { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Directions { get; set; } = "[]";

        public Customer() { }

        public Customer(string name, string lastName, string username, string password, string directions)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
            this.Directions = directions;
        }

        public override string ToString()
        {
            return $"{this.Name},{this.LastName},{this.Username},{this.Password},[]{Environment.NewLine}";
        }
    }
}
