using Microsoft.AspNetCore.SignalR;
using WEP.Controllers;

namespace WEP.Hubs
{
    public class ChatHub:Hub
    {
        
        public async Task SendMessage(string username,string message) 
        {
           await Clients.All.SendAsync("ReceiveMessage",username, message);
        }
    }
}
