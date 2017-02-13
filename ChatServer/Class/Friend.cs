using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatServer
{
    public class Friend
    {
        public Friend(int idUser, int idFriend)
        {
            this.IDUser = idUser;
            this.IDFriend = idFriend;
        }
        public Friend()
        {
        }
        public int ID { get; set; }

        public int IDUser { get; set; }

        public int IDFriend { get; set; }
    }
}