using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.SignalR;

namespace simpleChat.Hubs
{
    public class ChatHub : Hub
    {
        HashSet<myUser> onlineUsers = new HashSet<myUser>();
        public void Send(string name, string message)
        {
            // Call the addNewMessageToPage method to update clients.
            Clients.All.addNewMessageToPage(name, message);
            
        }

    }
}