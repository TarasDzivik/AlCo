namespace AlCollection.Data.Models
{
    /// <summary>
    /// The Object contains identities, names, and keys for connecting to the others tables.
    /// </summary>
    public class Country
    {
        #region Properties
        /// <summary>
        /// The id of the country name based on Alpha 2 code (only 2 digit)
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The full country name.
        /// </summary>
        public string LongName { get; set; }
        #endregion

        #region References
        /// <summary>
        /// A reference to the of references to the brands' products in that country.
        /// </summary>
        public List<Brand>? Brands { get; set; }
        /// <summary>
        /// A reference to the list of drinks created in the current contries.
        /// </summary>
        public List<Drink> Drinks { get; set; }
        /// <summary>
        /// A list of users belonging to the current country.
        /// </summary>
        public List<User> Users { get; set; }
        #endregion
    }
}
