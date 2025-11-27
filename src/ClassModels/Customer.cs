namespace ClassModels
{
    /// <summary>
    /// Model representing a customer.
    /// </summary>
    public class Customer
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        public Customer()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Customer"/> class.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <param name="lastName">The last name.</param>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <param name="directions">The directions.</param>
        public Customer(string name, string lastName, string username, string password, string directions)
        {
            this.Name = name;
            this.LastName = lastName;
            this.Username = username;
            this.Password = password;
            this.Directions = directions;
            this.CreateDirectionsFromStringArray(directions);
        }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public string Name { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the last name.
        /// </summary>
        /// <value>
        /// The last name.
        /// </value>
        public string LastName { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the username.
        /// </summary>
        /// <value>
        /// The username.
        /// </value>
        public string Username { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the password.
        /// </summary>
        /// <value>
        /// The password.
        /// </value>
        public string Password { get; set; } = string.Empty;

        /// <summary>
        /// Gets or sets the directions.
        /// </summary>
        /// <value>
        /// The directions.
        /// </value>
        public string Directions { get; set; } = "[]";

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>


        public override string ToString()
        {
            return $"{this.Name},{this.LastName},{this.Username},{this.Password},[]{Environment.NewLine}";
        }

        private void CreateDirectionsFromStringArray(string directionsInfo)
        {
            // Empty on purpose.
        }
    }
}
