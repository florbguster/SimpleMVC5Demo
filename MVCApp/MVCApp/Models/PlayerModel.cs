using MVCApp.DomainObjects;
using System.Collections.Generic;

namespace MVCApp.Models
{
    public class PlayerModel
    {
        public PlayerModel()
        {
            this.Users = GenerateUsers();
        }

        public List<Player> Users { get; set; }

        private List<Player> GenerateUsers()
        {
            List<Player> users = new List<Player> { 
                new Player{
                    ID = 1,
                    FirstName = "Diego",
                    LastName = "Maradona",
                    Phone = "7201231244",
                    EmailAddress = "Maradona1@test.com",
                    Active = false
                },
                new Player{
                    ID = 2,
                    FirstName = "Christiano",
                    LastName = "Ronaldo",
                    Phone = "5551114466",
                    EmailAddress = "ronaldo@msn.com",
                    Active = true
                },
                new Player{
                    ID = 3,
                    FirstName = "Roberto",
                    LastName = "Carlos",
                    Phone = "9997778545",
                    EmailAddress = "dummydata@yahoo.com",
                    Active = false
                },
                new Player{
                    ID = 4,
                    FirstName = "Alessandro",
                    LastName = "DelPiero",
                    Phone = "6665554411",
                    EmailAddress = "DelPiero@outlook.com",
                    Active = false
                },
                new Player{
                    ID = 5,
                    FirstName = "Zinedin",
                    LastName = "Zidane",
                    Phone = "4441112233",
                    EmailAddress = "Zidane@yahoo.com",
                    Active = false
                },
                new Player{
                    ID = 6,
                    FirstName = "Xavier",
                    LastName = "Barthez",
                    Phone = "8887774455",
                    EmailAddress = "Barthez@aol.com",
                    Active = false
                },
                new Player{
                    ID = 7,
                    FirstName = "Neymar",
                    LastName = "Da Silva Santos",
                    Phone = "8887774455",
                    EmailAddress = "Neymar145@aol.com",
                    Active = false
                },
                new Player{
                    ID = 8,
                    FirstName = "Zlatan",
                    LastName = "Ibrahimovic",
                    Phone = "8887774455",
                    EmailAddress = "Zlatan@aol.com",
                    Active = true
                },
                new Player{
                    ID = 9,
                    FirstName = "Ricardo",
                    LastName = "Kaka",
                    Phone = "8887774455",
                    EmailAddress = "kaka123@aol.com",
                    Active = true
                },
            };
            return users;
        }
    }
}