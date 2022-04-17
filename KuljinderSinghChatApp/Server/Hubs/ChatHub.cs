using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace KuljinderSinghChatApp.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);

        }
        public Task SendMessageToCaller(string user, string message)
        {
            return Clients.Caller.SendAsync("ReceivingMessageFromAuser", user + " something special", message);
        }
        public Task SendMessageToGroup(string user, string message)
        {
            return Clients.Group("SignalR users").SendAsync("ReceivingMessageFromAuser", user, message);
        }
    }
}
