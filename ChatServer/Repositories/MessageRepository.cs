using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatServer
{
    public class MessageRepository
    {
        private MyContext _context = new MyContext();


        public List<Message> FindAll()
        {
            return this._context.Messages.ToList<Message>();
        }

        public Message FindById(int id)
        {
            return this._context.Messages.Find(id);
        }


        public void AddMessage(Message m)
        {
            this._context.Messages.Add(m);

            this._context.SaveChanges();
        }


        public void UpdateMessage(Message m)
        {
            Message dbMessage = this.FindById(m.ID);

            dbMessage.DateSend = m.DateSend;
            dbMessage.Recieved = m.Recieved;
            dbMessage.IDSender = m.IDSender;
            dbMessage.IDReciever = m.IDReciever;
            dbMessage.IDRoom = m.IDRoom;
            dbMessage.Text = m.Text;

            this._context.SaveChanges();

        }


        public void DeletedbMessage(int id)
        {
            Message m = this.FindById(id);
            this._context.Messages.Remove(m);
            this._context.SaveChanges();
        }
    }
}