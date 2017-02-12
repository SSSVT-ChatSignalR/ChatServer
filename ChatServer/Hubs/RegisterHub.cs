using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatServer.Hubs
{
    public class RegisterHub : Hub
    {
        private UserRepository _userRepository = new UserRepository();
        public bool AddUser(string nick, string password, string name, string surname, int age, string email)
        {
            string passwordMD5 = PasswordCoding.CalculateMD5Hash(password);
            User usr = new User(nick, passwordMD5, name, surname, age, email);
            this._userRepository.AddUser(usr);
            return true;
        }

    }
}