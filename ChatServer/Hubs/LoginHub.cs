using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatServer.Hubs
{
    public class LoginHub : Hub
    {
        private UserRepository _userRepository = new UserRepository();
        public string Login(string nick, string password)
        {
            string passwordMD5 = PasswordCoding.CalculateMD5Hash(password);
            
            User user = this._userRepository.LoginUser(nick, passwordMD5);
            if (user == null)
                return null;
            else
            {
                user.ConnectionID = PasswordCoding.RandomString(20);
                this._userRepository.UpdateUser(user);
                return user.ConnectionID;//Clients.All.Login("Přihlášen");
            }//
        }
    }
}