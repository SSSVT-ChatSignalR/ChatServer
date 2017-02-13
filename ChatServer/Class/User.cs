using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatServer
{
    public class User
    {
        public User(string nick, string password, string name, string surname, int age, string email)
        {
            this.Nick = nick;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Email = email;
        }
        public User()
        {
        }
        public int ID { get; set; }

        public string Nick { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConnectionID { get; set; }

    }
}