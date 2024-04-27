using Microsoft.AspNetCore.Mvc;
using Yavuz_Selim_Yazıcı.DAL.Context;

namespace Yavuz_Selim_Yazıcı.ViewComponents
{
    public class _AboutComponentPartial : ViewComponent
    {
        MyPortfoiloContext portfoiloContext = new MyPortfoiloContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.aboutTitle = portfoiloContext.Abouts.Select(x => x.Title).FirstOrDefault();
            ViewBag.aboutSubDescription = portfoiloContext.Abouts.Select(x => x.SubDescription).FirstOrDefault();
            ViewBag.aboutDetail = portfoiloContext.Abouts.Select(x => x.Details).FirstOrDefault();
            return View(ViewBag);
        }
    }
}
