using Microsoft.AspNetCore.Mvc;

namespace BibliotecaTeste.Controllers
{
    public class EmprestimoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}