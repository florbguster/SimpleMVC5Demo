using System.ComponentModel;

namespace MVCApp.Models
{
    public class User
    {
        [DisplayName("User ID")]
        public int ID { get; set; }

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Phone")]
        public string Phone { get; set; }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Active")]
        public bool Active { get; set; }

    }
}
