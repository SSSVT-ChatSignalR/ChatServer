using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatServer.Hubs
{
    public class LoginHub : Hub
    {
        private UserRepository _uRepository = new UserRepository();
        public bool Login(string nick, string password)
        {
            string passwordMD5 = PasswordCoding.CalculateMD5Hash(password);
            
            User user = this._uRepository.LoginUser(nick, passwordMD5);
            if (user == null)
                return false;
            else
                return true;//Clients.All.Login("Přihlášen");
        }
    }
}