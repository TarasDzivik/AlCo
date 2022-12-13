namespace AlCollection.Data.Models
{
    /// <summary>
    /// The object is used to connect users with the drinks they have tasted.
    /// </summary>
    public class UserCollection
    {
        /// <summary>
        /// Tht personal id of the collection of the current User
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// Refferance to a User
        /// </summary>
        public User User { get; set; }
        /// <summary>
        /// Refferance to a drink
        /// </summary>
        public List<UserDrink> Drinks { get; set; }
    }
}
