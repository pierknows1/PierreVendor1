
using Microsoft.AspNetCore.Mvc;


namespace PierreVendor.Controllers
{
public class HomeController : Controller
{
   
[HttpGet("/")]
    public ActionResult Index()
    {
        return View();
    }
}

}

