


public partial class Library
{
    // Utente
    public class User
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        protected string email { get; set; }
        public string password { get; set; }
        protected long phoneNumber { get; set; }

        public User(string firstName, string lastName, string email, string password, long phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;   
            this.email = email; 
            this.password = password;
            this.phoneNumber = phoneNumber;
        }
    }
}


