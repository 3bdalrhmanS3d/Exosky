using Exosky.Models;
using Exosky.Repositories;
using Microsoft.AspNetCore.SignalR;

namespace Exosky.Hubs
{
    public class ChatHub :Hub
    {
        private readonly IChatRepository _chatRepository;

        public ChatHub(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }


        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }


    }
}
