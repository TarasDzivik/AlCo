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
        /// The first Name is optional because of privacy of the User.
        /// </summary>
        public string? FirstName { get; set; }
        /// <summary>
        /// The Second Name is optional because of privacy of the User.
        /// </summary>
        public string? SecondName { get; set; }
        /// <summary>
        /// The User's Date Of Birthday (required for statistics).
        /// </summary>
        public DateOnly DateOfBirthday { get; set; }
        /// <summary>
        /// The User's gender (ex: 1 - Male, 2 - Female, 3 - Other)
        /// </summary>
        #endregion
        #region References
        public int Gender { get; set; }
        /// <summary>
        /// The Citizenship is a kay for a User's country.
        /// </summary>
        public Country Citizenship { get; set; }
        #endregion
    }
}
