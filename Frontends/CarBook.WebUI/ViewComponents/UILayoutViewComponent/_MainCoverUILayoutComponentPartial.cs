using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace CarBook.WebUI.ViewComponents.UILayoutViewComponent
{
    public class _MainCoverUILayoutComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke(){
            return View();
        }
    }
}