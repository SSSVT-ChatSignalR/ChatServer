using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatServer
{
    public class UserRepository
    {

        private MyContext _context = new MyContext();


        public List<User> FindAll()
        {
            return this._context.Users.ToList<User>();
        }

        public User FindById(int id)
        {
            return this._context.Users.Find(id);
        }


        public void AddUser(User u)
        {
            this._context.Users.Add(u);

            this._context.SaveChanges();
        }


        public void UpdateUser(User u)
        {
            User dbUser = this.FindById(u.ID);

            dbUser.Nick = u.Nick;
            dbUser.Name = u.Name;
            dbUser.Surname = u.Surname;
            dbUser.Age = u.Age;
            dbUser.Email = u.Email;
            dbUser.Password = u.Password;
            dbUser.ConnectionID = u.ConnectionID;

            this._context.SaveChanges();

        }


        public void DeleteUser(int id)
        {
            User u = this.FindById(id);
            this._context.Users.Remove(u);
            this._context.SaveChanges();
        }
    }
}