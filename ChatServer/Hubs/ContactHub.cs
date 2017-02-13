using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace ChatServer.Hubs
{
    public class ContactHub : Hub
    {
        private FriendRepository _friendRepository = new FriendRepository();
        private UserRepository _userRepository = new UserRepository();

        public bool AddFriend(string userConnectionID, string friend)
        {
            User user = this._userRepository.FindByConnectionID(userConnectionID);
            User user_friend = this._userRepository.FindByNick(friend);
            int idUser = user.ID;
            int idFriend = user_friend.ID;

            Friend frn = new Friend(idUser, idFriend);
            this._friendRepository.AddFriend(frn);
            return true;
        }
    }
}