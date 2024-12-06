using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace AirlineTicketsSystemGui.model
{
    public class Staff : User
    {
        public Staff(int userId, string email, string password) : base(userId, email, password)
        {
            this.UserId = userId;
            this.Email = email;
            this.Password = password;
        }

        public override string ToString()
        {
            return $"UserID: {UserId}, Email: {Email}, Password: {Password}";
        }
    }

    
}