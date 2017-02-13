using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatServer
{
    public class FriendRepository
    {
        private MyContext _context = new MyContext();


        public List<Friend> FindAll()
        {
            return this._context.Friends.ToList<Friend>();
        }

        public Friend FindById(int id)
        {
            return this._context.Friends.Find(id);
        }


        public void AddFriend(Friend f)
        {
            this._context.Friends.Add(f);

            this._context.SaveChanges();
        }


        public void UpdateFriend(Friend f)
        {
            Friend dbFriend = this.FindById(f.ID);

            dbFriend.IDFriend = f.IDFriend;
            dbFriend.IDUser = f.IDUser;

            this._context.SaveChanges();

        }

        public void DeletedbFriend(int id)
        {
            Friend f = this.FindById(id);
            this._context.Friends.Remove(f);
            this._context.SaveChanges();
        }
        public List<Friend> FindByUserID(int id)
        {
            return FindAll().Where(x => x.IDUser == id).ToList<Friend>();
        }
    }
}