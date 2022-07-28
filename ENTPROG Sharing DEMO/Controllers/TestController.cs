using Microsoft.AspNetCore.Mvc;

namespace ENTPROG_Sharing_DEMO.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
