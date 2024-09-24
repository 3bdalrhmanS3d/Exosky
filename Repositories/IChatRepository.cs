using Exosky.Models;

namespace Exosky.Repositories
{
    public interface IChatRepository
    {
        IEnumerable<ChatMessage> GetChatHistory();  // Fetch all recent messages
        void AddMessage(ChatMessage message);  // Add a new chat message
    }
}
