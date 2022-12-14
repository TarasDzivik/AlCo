namespace AlCollection.Data.Models
{
    /// <summary>
    /// The Object contain a feedbacks of the users.
    /// </summary>
    public class UserFeedback
    {
        /// <summary>
        /// The reference to the User.
        /// </summary>
        //TODO: To figure out if you need to get the user id here or just User is enough
        public User User { get; set; }
        /// <summary>
        /// The reference to a Drink.
        /// </summary>
        public Drink Drink { get; set; }
        /// <summary>
        /// The first comment should contain a short description of how the drink tastes.
        /// </summary>
        public string? FirstComment { get; set; }
        /// <summary>
        /// The second comment should include how the customer feels a few days after of drinking it.
        /// </summary>
        public string? SecondComment { get; set; }
    }
}
