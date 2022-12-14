namespace AlCollection.Data.Models
{
    /// <summary>
    /// The Object contain User properties (Id, NickName, Email, DateOfBirthday, Gender, Citizenship)
    /// </summary>
    public class User
    {
        #region Fields
        /// <summary>
        /// The User's Id 
        /// </summary>
        public Guid Id { get; set; }
        /// <summary>
        /// The User's email (required for SignUp/login)
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// The User's Nickname (required for comments)
        /// </summary>
        public string Nickname { get; set; }
        /// <summary>
        /// The User's Date Of Birthday (required for statistics).
        /// </summary>
        public DateOnly DateOfBirthday { get; set; }
        /// <summary>
        /// The User's gender should be only 3 types (ex: 1 - Male, 2 - Female, null - Other).
        /// </summary>
        public string? Gender { get; set; }
        /// <summary>
        /// The first Name is optional because of privacy of the User.
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// The second Name is optional because of privacy of the User.
        /// </summary>
        public string? SecondName { get; set; }
        #endregion
        #region References
        /// <summary>
        /// The reference to the citizenship of the User.
        /// </summary>
        public Country Citizenship { get; set; }
        /// <summary>
        /// The reference to the collection of drinks that the user tasted.
        /// </summary>
        public UserCollection Collection { get; set; }
        #endregion
    }
}
