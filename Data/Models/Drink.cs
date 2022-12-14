namespace AlCollection.Data.Models
{
    /// <summary>
    /// This object contains properties and the keys of the Drink (ex. Id, Name, Type, Country)
    /// </summary>
    public class Drink
    {
        #region Property
        /// <summary>
        /// Drink Id
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Name of this alcohol (example: "Sheridan's", "Tennessee Honey")
        /// </summary>
        public string DrinkName { get; set; }
        /// <summary>
        /// The "Alcohol by volume" how much alcohol (ethanol) is contained in a given volume
        /// of an alcoholic beverage (expressed as a volume percent).
        /// </summary>
        public double? ABV { get; set; }
        /// <summary>
        /// Users ratings are Raiting measures of customer satisfaction.
        /// </summary>
        //TODO: to make autoscraper and calculating Rating from User perconal raitings
        public double? Rating { get; set; }
        /// <summary>
        /// The key to the company that prodused that alcohol
        /// </summary>
        #endregion
        #region References
        public Brand? BrandName { get; set; }
        /// <summary>
        /// The key to the Type of the Drink.
        /// </summary>
        public DrinkType Type { get; set; }
        /// <summary>
        /// The reference to the country created that drink.
        /// </summary>
        public Country Country { get; set; }
        /// <summary>
        /// The list of the Users Feedbacks.
        /// </summary>
        public List<UserFeedback>? Feedbacks { get; set; }
        #endregion
    }
}
