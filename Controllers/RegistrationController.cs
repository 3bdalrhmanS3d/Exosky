using Exosky.Data;
using Exosky.Models;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography;
using System.Text;

namespace Exosky.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly AppDbContext _context;
        public RegistrationController(AppDbContext context)
        {
            _context = context;
        }

        public class UserInput
        {
            public string UserFName { get; set; }
            public string UserLName { get; set; }
            public string Email { get; set; } 
            public string Password { get; set; }
            public DateTime BarthDay { get; set; }
        }
        [BindProperty]
        public UserInput input { get; set; }

        [HttpGet]
        public IActionResult Index()
        {
            ViewBag.message = "Welcome";
            return View();
        }

        // Post  /Registration/
        [HttpPost]
        [ValidateAntiForgeryToken]

        public async Task<IActionResult> Index(UserInput input)
        {
            if (ModelState.IsValid)
            {
                var existingEmail = _context.Users.SingleOrDefault(i=>i.Email == input.Email);
                if (existingEmail != null)
                {
                    TempData["message"] = "User already exists";
                    return RedirectToAction("Index","Login");

                }

                var user = new User
                {
                    UserName = input.UserFName + " " + input.UserLName,
                    Email = input.Email,
                    Password = HashPassword(input.Password),
                    BarthDay = input.BarthDay
                };

                _context.Users.Add(user);
                await _context.SaveChangesAsync();

                TempData["message"] = "Registration successful";
                return RedirectToAction("Index", "Login");

            }
            else
            {
                ViewBag.message = "Registration failed";
                return View(input);
            }
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);

                StringBuilder result = new StringBuilder();
                foreach (byte b in hash)
                {
                    result.Append(b.ToString("x2"));
                }

                return result.ToString();
            }
        }
    }
}
