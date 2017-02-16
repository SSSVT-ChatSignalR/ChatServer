using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatServer
{
    public class UserRoomRepository
    {
                
        private MyContext _context = new MyContext();


        public List<UserRoom> FindAll()
        {
            return this._context.UserRooms.ToList<UserRoom>();
        }

        public UserRoom FindById(int id)
        {
            return this._context.UserRooms.Find(id);
        }


        public void AddUserRoom(UserRoom ur)
        {
            this._context.UserRooms.Add(ur);

            this._context.SaveChanges();
        }


        public void UpdateRoom(UserRoom ur)
        {
            UserRoom dbUserRoom = this.FindById(ur.ID);

            dbUserRoom.IDUser = ur.IDUser;
            dbUserRoom.IDRoom = ur.IDRoom;

            this._context.SaveChanges();

        }


        public void DeletedbUserRoom(int id)
        {
            UserRoom ur = this.FindById(id);
            this._context.UserRooms.Remove(ur);
            this._context.SaveChanges();
        }
    }
}