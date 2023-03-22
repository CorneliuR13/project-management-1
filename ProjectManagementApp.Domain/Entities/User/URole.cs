namespace ProjectManagementApp.Domain.Entities.User
{
    public class URole
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Role UserRole { get; set; }
    }

    public enum Role
    {
        Admin,
        Manager,
        Employee,
        Guest
    }
}