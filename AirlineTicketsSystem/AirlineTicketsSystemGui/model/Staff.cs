namespace AirlineTicketsSystemGui.model
{
    public class Staff : User
    {
        public Staff(int userId, string email, string password) : base(userId, email, password)
        {
        }

        public override string ToString()
        {
            return $"{UserId} | {Email}";
        }
    }
}