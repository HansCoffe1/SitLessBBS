using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBS.Web.Components
{
    public class MyInfoTabViewComponent: ViewComponent
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        /// <returns></returns>
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
