using Microsoft.AspNetCore.Mvc;

namespace Yavuz_Selim_Yazıcı.ViewComponents
{
    public class _HomeComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
