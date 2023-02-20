using Microsoft.AspNetCore.Mvc;

namespace ASM_1670_FPTBook.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
