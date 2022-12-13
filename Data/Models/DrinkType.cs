namespace AlCollection.Data.Models
{
    /// <summary>
    /// The Object contains еhe name of the drink type (ex. Bear, Liquor, Whiskey).
    /// </summary>
    public class DrinkType
    {
        /// <summary>
        /// The Id of the Drink Type
        /// </summary>
        public int Id { get; set; }
        /// <summary>
        /// The Name of the Drink Type (ex. Bear, Liquor, Whiskey).
        /// </summary>
        public string Type { get; set; }
        /// <summary>
        /// The List of the same type of drinks.
        /// </summary>
        public List<Drink> Drinks { get; set; }
    }
}
