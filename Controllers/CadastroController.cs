using Microsoft.AspNetCore.Mvc;

namespace SenaiMVC.Controllers
{
    public class CadastroController: Controller
    {
        public IActionResult Sala()
        {
            return View();
        }
    }
}