using Microsoft.AspNetCore.Mvc;
using Yavuz_Selim_Yazıcı.DAL.Context;

namespace Yavuz_Selim_Yazıcı.ViewComponents
{
    public class _ExperienceComponentPartial : ViewComponent
    {
        MyPortfoiloContext portfoiloContext = new MyPortfoiloContext();
        public IViewComponentResult Invoke()
        {
            var values = portfoiloContext.Experiences.ToList();
            return View(values);
        }
    }
}
