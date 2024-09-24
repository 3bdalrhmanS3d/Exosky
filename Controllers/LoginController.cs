using Exosky.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography;
using System.Text;

namespace Exosky.Controllers
{
    public class LoginController : Controller
    {
        private readonly AppDbContext _context;

        public LoginController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult Index()
        {

            return View();
        }

        public class LoginInput
        {
            [Required]
            [EmailAddress]
            public string userEmail { get; set; }

            [Required]
            public string userPassword { get; set; }
        }

        [BindProperty]
        public LoginInput input { get; set; }

        [HttpPost]
        public async Task<IActionResult> Index(LoginInput input)
        {

            var Xuser = await _context.Users.SingleOrDefaultAsync(x => x.Email == input.userEmail);

            if (Xuser != null && VerifyPassword(input.userPassword, Xuser.Password))
            {
                HttpContext.Session.SetString("UserId", Xuser.Id.ToString() );
                
                return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Message = "Invalid Email or Password";
                return View();
            }
        }

        private bool VerifyPassword(string inputuserpassword, string userpassword)
        {
            if (HashPassword(inputuserpassword) == userpassword)
            {
                return true;
            }
            return false;
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
        public IActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "Home");
        }
       

    }
}
