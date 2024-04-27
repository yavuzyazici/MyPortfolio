using Microsoft.AspNetCore.Mvc;
using Yavuz_Selim_Yazıcı.DAL.Context;

namespace Yavuz_Selim_Yazıcı.ViewComponents
{
    public class _FeatureComponentPartial : ViewComponent
    {
        MyPortfoiloContext portfoiloContext = new MyPortfoiloContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfoiloContext.Features.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutDescription = portfoiloContext.Features.Select(x => x.Description).FirstOrDefault();
            return View(ViewBag);
        }
    }
}
