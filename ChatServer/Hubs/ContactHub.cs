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

        public void AddFriend(string userConnectionID, string friend)
        {
            User user = this._userRepository.FindByConnectionID(userConnectionID);
            User user_friend = this._userRepository.FindByNick(friend);
            if (user_friend != null)
            {
                int idUser = user.ID;
                int idFriend = user_friend.ID;

                Friend frn = new Friend(idUser, idFriend);
                this._friendRepository.AddFriend(frn);
            }
            else
                friend = null;
            Clients.All.WriteFriend(friend);
        }
        public void GetFriends(string userConnectionID)
        {
            List<string> friendsListString = new List<string>();
            User user = this._userRepository.FindByConnectionID(userConnectionID);
            int idUser = user.ID;
            List<Friend> friendsListFriends = this._friendRepository.FindByUserID(idUser);
            foreach (Friend item in friendsListFriends)
            {
                User _tempUsr = this._userRepository.FindById(item.IDFriend);
                friendsListString.Add(_tempUsr.Nick);
            }
            Clients.All.WriteFriends(friendsListString);
            //return friendsListString;
        }
        public List<string> WriteAllMembers()// string userConnectionID - Bezpečnost
        {
            List<string> membersListString = new List<string>();

            List<User> usersListUsers = this._userRepository.FindAll();
            foreach (User item in usersListUsers)
            {
                User _tempUsr = this._userRepository.FindById(item.ID);
                membersListString.Add(_tempUsr.Nick);
            }
            return membersListString;
        }
    }
}