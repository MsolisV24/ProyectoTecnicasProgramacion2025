namespace ClassProyecto
{
    /// <summary>
    /// Set of methods to validate arguments.
    /// </summary>
    public static class ArgumentValidator
    {
        /// <summary>
        /// Parses the string to int.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>the integer equivalent to the string or -1 if error.</returns>
        public static int ParseStringToInt(this string value)
        {
            if (!int.TryParse(value, out int result))
            {
                throw new ArgumentException($"The provided value is not a valid integer. Parameter {value}");
            }

            return result;
        }

        /// <summary>
        /// Validates the string.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <returns>true if string is nor empty or null.</returns>
        public static bool IsValidadString(this string value)
        {
            return !string.IsNullOrEmpty(value);
        }
    }
}
