namespace AirlineTicketsSystemGui.model
{
    public abstract class User
    {
        protected User(int userId, string email, string password)
        {
            UserId = userId;
            Email = email;
            Password = password;
        }

        public int UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
    }
}