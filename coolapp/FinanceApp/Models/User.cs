namespace  FinanceApp.Models
{
    public class User : BaseEntity
    {

        public string Name { get; set; }

        public string Password { get; set; }
        public string Role { get; set; }
        public string PhoneNumber { get; set; }

        public string Email { get; set; }


    }
}