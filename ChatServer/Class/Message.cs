using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatServer
{
    public class Message
    {
        public int ID { get; set; }

        public DateTime DateSend { get; set; }

        public bool Recieved { get; set; }

        public int IDSender { get; set; }

        public int IDReciever { get; set; }

        public int IDRoom { get; set; }

        public string Text { get; set; }
    }
}