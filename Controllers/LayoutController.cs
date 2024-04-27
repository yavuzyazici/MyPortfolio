using Microsoft.AspNetCore.Mvc;

namespace Yavuz_Selim_Yazıcı.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
