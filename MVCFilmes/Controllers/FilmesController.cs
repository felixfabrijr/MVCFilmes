using Microsoft.AspNetCore.Mvc;

namespace MVCFilmes.Controllers
{
    public class FilmesController : Controller
    {
        public string Index()
        {
            return "Action Padrao";
        }

        public string Welcome() => "Seja bem vindo";
    }
}
