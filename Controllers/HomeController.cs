using Microsoft.AspNetCore.Mvc;

namespace PrimeiroProxecto.Controllers;

public class HomeController : Controller
{
    //accion simple definida por HomeController, chamada Index
    public ViewResult Index()
    {
        int hora = DateTime.Now.Hour;
        string viewModel = hora < 12 ? "Bos dias" : "Boas noites";
        return View("MinhaView", viewModel);
    }

}
