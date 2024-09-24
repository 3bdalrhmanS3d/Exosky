using Exosky.Models;
using Exosky.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace Exosky.Controllers
{
    public class ChatController : Controller
    {
        private readonly IChatRepository _chatRepository;

        // Constructor injection of the repository
        public ChatController(IChatRepository chatRepository)
        {
            _chatRepository = chatRepository;
        }

        public IActionResult Index()
        {
            var chatHistory = _chatRepository.GetChatHistory();
            return View(chatHistory);
        }
        public IActionResult ChatRoom()
        {
            var loggedInUser = HttpContext.Session.GetString("UserId"); // Fetch logged-in user
            ViewBag.LoggedInUser = loggedInUser; // Pass it to the view
            return View();
        }

      
    }
}
