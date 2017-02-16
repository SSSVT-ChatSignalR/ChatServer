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
        private FriendRepository _friendRepository = new FriendRepository();
        private MessageRepository _messageRepository = new MessageRepository();
        //Doupravit tak, aby šĺo chatovat pouze s přátelama
        public bool CheckContact(string nick, string connectionID)
        {
            User userN = this._userRepository.FindByNick(nick);
            User userC = this._userRepository.FindByConnectionID(connectionID);
            Friend frn = this._friendRepository.FindByFriendIDAndUserID(userN.ID, userC.ID);

            if (frn != null)
                return true;
            return false;
        }
        public void SendMessage(string ConnectionID, string message, string nickFriend)
        {
            User sender = this._userRepository.FindByConnectionID(ConnectionID);
            int idSender = sender.ID;

            User reciever = this._userRepository.FindByNick(nickFriend);
            int idReciever = reciever.ID;

            DateTime dateNow = DateTime.Now;
            Message msg = new Message(dateNow, true, idSender, idReciever, -1, message);
            this._messageRepository.AddMessage(msg);
            Clients.All.WriteMessage(message, dateNow.ToString("yyyy-dd-MM-hh-mm"));
        }
    }
}