using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBS.Web.Components
{
    public class UserInfoTabViewComponent: ViewComponent
    {
        /// <summary>
        /// 用户信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(int id)
        {
            return View(id);
        }
    }
}
