﻿using Microsoft.AspNetCore.Mvc;

namespace Yavuz_Selim_Yazıcı.ViewComponents
{
    public class _StatisticComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
