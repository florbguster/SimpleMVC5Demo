using System.ComponentModel;
using System.Text.RegularExpressions;

namespace MVCApp.DomainObjects
{
    public class Player : Individual
    {
        private string _phone;

        [DisplayName("First Name")]
        public string FirstName { get; set; }

        [DisplayName("Last Name")]
        public string LastName { get; set; }

        [DisplayName("Phone")]
        public string Phone
        {
            get
            {
                return Regex.Replace(_phone, ".*?(\\d{3}).*?(\\d{3}).*?(\\d{4}).*?", "($1) $2-$3");
            }
            set { _phone = value; }
        }

        [DisplayName("Email Address")]
        public string EmailAddress { get; set; }

        [DisplayName("Active")]
        public bool Active { get; set; }

    }
}
