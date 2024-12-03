namespace AirlineTicketsSystemGui.controller
{
    public class AdminController
    {
        private static string AdminKey { get; set; } = "adminkey";

        public static bool IsKey(string key)
        {
            return key.Equals(AdminKey);
        }

        public static void ChangeKey(string newKey)
        {
            AdminKey = newKey;
        }
    }
}