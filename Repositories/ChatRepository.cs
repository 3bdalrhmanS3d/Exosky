using Exosky.Data;
using Exosky.Models;
using Microsoft.EntityFrameworkCore;

namespace Exosky.Repositories
{
    public class ChatRepository : IChatRepository
    {
      
        private readonly AppDbContext _context;

        public ChatRepository(AppDbContext context)
        {
            _context = context;
        }

        // Fetches the chat history (you can limit this to a certain number of messages)
        public IEnumerable<ChatMessage> GetChatHistory()
        {
            return _context.ChatMessages.OrderByDescending(m => m.SentTime).Take(50).ToList();
        }

        // Adds a new message to the database
        public void AddMessage(ChatMessage message)
        {
            message.SentTime = DateTime.Now;  // Automatically set the sent time
            _context.ChatMessages.Add(message);
            _context.SaveChanges();  // Commit the changes to the database
        }

        // Optional: You can also add a method to get all chat messages
      
    }
}
