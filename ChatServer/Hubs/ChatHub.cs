using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatServer.Hubs
{
    public class ChatHub : Hub
    {
        private UserRepository _userRepository = new UserRepository();
        //Doupravit tak, aby šĺo chatovat pouze s přátelama
        public bool CheckContact(string nick)
        {
            User user = this._userRepository.FindByNick(nick);
            if (user != null)
                return true;
            return false;
        }
        public void SendMessage(string ConnectionID, string message, string nickFriend)
        {
            DateTime dateNow = DateTime.Now;
        }
    }
}