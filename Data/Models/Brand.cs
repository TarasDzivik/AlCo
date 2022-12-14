namespace AlCollection.Data.Models
{
    /// <summary>
    /// The Object contains information about the creators of a drink.
    /// </summary>
    public class Brand
    {

        /// <summary>
        /// The Id of the Brand
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// The Name of the company that produces an Drink (example: "Thomas Sheridan & Sons", "Jack Daniel's ")
        /// </summary>
        public string? BrandName { get; set; }

        #region References
        /// <summary>
        /// The List of productions that the Brand produced.
        /// </summary>
        public List<Drink> Drinks { get; set; }
        /// <summary>
        /// The key to a country where the brand started its business.
        /// </summary>
        public Country BrandCountry { get; set; }
        #endregion
    }
}
