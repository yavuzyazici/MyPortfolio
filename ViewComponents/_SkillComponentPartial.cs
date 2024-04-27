using Microsoft.AspNetCore.Mvc;
using Yavuz_Selim_Yazıcı.DAL.Context;

namespace Yavuz_Selim_Yazıcı.ViewComponents
{
    public class _SkillComponentPartial : ViewComponent
    {
        MyPortfoiloContext portfolioContext = new MyPortfoiloContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Features.ToList();
            return View(values);
        }
    }
}
