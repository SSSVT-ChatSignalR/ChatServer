﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChatServer
{
    public class User
    {
        public int ID { get; set; }

        public string Nick { get; set; }

        public string Name { get; set; }

        public string Surname { get; set; }

        public int Age { get; set; }

        public string Email { get; set; }

        public string Password { get; set; }

        public string ConnectionID { get; set; }

    }
}