using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace SignalR_Practice.Operations
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
