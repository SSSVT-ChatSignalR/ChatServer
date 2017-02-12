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
            User usr = new User(nick, password, name, surname, age, email);
            this._userRepository.AddUser(usr);
            return true;
        }

    }
}