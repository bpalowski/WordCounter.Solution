using Microsoft.AspNetCore.Mvc;

namespace WordCounter.Controllers
{
    public class HomeController : Controller
    {

         [HttpGet("/")]//home file//index


        public ActionResult Index()
        {
          return new ViewResult();
        }


    }
}
