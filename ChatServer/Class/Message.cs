using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatServer
{
    public class Message
    {
        public Message(DateTime dateSend, bool recieved, int iDSender, int iDReciever, int iDRoom, string text)
        {
            this.DateSend = dateSend;
            this.Recieved = recieved;
            this.IDSender = iDSender;
            this.IDReciever = iDReciever;
            this.IDRoom = iDRoom;
            this.Text = text;
        }
        public Message()
        {
        }
        public int ID { get; set; }

        public DateTime DateSend { get; set; }

        public bool Recieved { get; set; }

        public int IDSender { get; set; }

        public int IDReciever { get; set; }

        public int IDRoom { get; set; }

        public string Text { get; set; }
    }
}