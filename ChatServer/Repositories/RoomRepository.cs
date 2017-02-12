using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatServer.Repositories
{
    public class RoomRepository
    {
        
        private MyContext _context = new MyContext();


        public List<Room> FindAll()
        {
            return this._context.Rooms.ToList<Room>();
        }

        public Room FindById(int id)
        {
            return this._context.Rooms.Find(id);
        }


        public void AddRoom(Room r)
        {
            this._context.Rooms.Add(r);

            this._context.SaveChanges();
        }


        public void UpdateRoom(Room r)
        {
            Room dbRoom = this.FindById(r.ID);

            dbRoom.Name = r.Name;

            this._context.SaveChanges();

        }


        public void DeletedbRoom(int id)
        {
            Room r = this.FindById(id);
            this._context.Rooms.Remove(r);
            this._context.SaveChanges();
        }
    }
}