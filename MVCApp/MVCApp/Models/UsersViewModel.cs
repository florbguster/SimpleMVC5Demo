using System.Collections.Generic;

namespace MVCApp.Models
{
    public class UsersViewModel
    {
        public UsersViewModel()
        {
            this.Users = GenerateUsers();
        }

        public List<User> Users { get; set; }

        private List<User> GenerateUsers()
        {
            List<User> users = new List<User> { 
                new User{
                    ID = 1,
                    FirstName = "Diego",
                    LastName = "Maradona",
                    Phone = "7201231244",
                    EmailAddress = "Maradona1@test.com",
                    Active = true
                },
                new User{
                    ID = 2,
                    FirstName = "Christiano",
                    LastName = "Ronaldo",
                    Phone = "5551114466",
                    EmailAddress = "ronaldo@msn.com",
                    Active = false
                },
                new User{
                    ID = 3,
                    FirstName = "Roberto",
                    LastName = "Carlos",
                    Phone = "9997778545",
                    EmailAddress = "dummydata@yahoo.com",
                    Active = false
                },
                new User{
                    ID = 4,
                    FirstName = "Alessandro",
                    LastName = "DelPiero",
                    Phone = "6665554411",
                    EmailAddress = "DelPiero@outlook.com",
                    Active = true
                },
                new User{
                    ID = 5,
                    FirstName = "Zinedin",
                    LastName = "Zidane",
                    Phone = "4441112233",
                    EmailAddress = "Zidane@yahoo.com",
                    Active = true
                },
                new User{
                    ID = 6,
                    FirstName = "Xavier",
                    LastName = "Barthez",
                    Phone = "8887774455",
                    EmailAddress = "Barthez@aol.com",
                    Active = false
                },
                new User{
                    ID = 7,
                    FirstName = "Anton",
                    LastName = "Pavlov",
                    Phone = "8887774455",
                    EmailAddress = "Pavlov@aol.com",
                    Active = false
                },
                new User{
                    ID = 8,
                    FirstName = "Marcus",
                    LastName = "Platoff",
                    Phone = "8887774455",
                    EmailAddress = "PlatoffMarcus@aol.com",
                    Active = false
                },
                new User{
                    ID = 9,
                    FirstName = "Abraham",
                    LastName = "Kaffka",
                    Phone = "8887774455",
                    EmailAddress = "Kaffka@aol.com",
                    Active = false
                },
            };
            return users;
        }
    }
}