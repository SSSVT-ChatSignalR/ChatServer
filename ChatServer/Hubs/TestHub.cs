using System;
using System.Web;
using Microsoft.AspNet.SignalR;
namespace SignalRChat
{
    public class TestHub : Hub
    {
        //Testing class
        public void Send(string name, string message)
        {
            Clients.All.broadcastMessage(name, message);
        }
        public void Announce(string message)
        {
            Clients.All.Announce(message);
        }
    }
}