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
        public DateTime DegustatingDay { get; set; } = DateTime.Now.Date;
        /// <summary>
        /// The current age of the custommer, when he/she taste that drink for a first time.
        /// </summary>
        // TODO: Create autogeneration of this property.
        public int AgeOfColectors { get; set; }
        /// <summary>
        /// Personal evaluation of the drink by the user.
        /// </summary>
        public double? Rating { get; set; }
        #endregion
        #region References
        /// <summary>
        /// The reference to a current User.
        /// </summary>
        public UserCollection Collection { get; }
        /// <summary>
        /// The reference to a current Drink.
        /// </summary>
        public Drink Drink { get; }
        #endregion
    }
}
