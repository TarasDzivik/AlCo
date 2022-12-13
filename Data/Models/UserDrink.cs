namespace AlCollection.Data.Models
{
    /// <summary>
    /// The Objects extend the Basic Drink object and add a new personal fitures from User
    /// </summary>
    public class UserDrink
    {
        #region Fields
        /// <summary>
        /// The day when a user a first time taste that drink.
        /// </summary>
        public DateTime DegustatinDay { get; set; } = DateTime.Now.Date;
        /// <summary>
        /// The current age of the custommer, when he/she taste that drink for a first time.
        /// </summary>
        public int AgeOfColectors { get; set; }
        /// <summary>
        /// Users ratings are quantitative measures of customer satisfaction.
        /// </summary>
        public double? Raiting { get; set; }
        #endregion
        #region References
        /// <summary>
        /// The reference to a current User.
        /// </summary>
        public User User { get; }
        /// <summary>
        /// The reference to a current Drink.
        /// </summary>
        public Drink Drink { get; }
        #endregion
    }
}
