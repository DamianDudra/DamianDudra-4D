namespace WebApplication3.Models
{
    public class User
    {
        public Guid UserPublicId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int Age { get; set; }
        public List<string> Vlastnosti { get; set; } = new List<string>(); 
    }
}