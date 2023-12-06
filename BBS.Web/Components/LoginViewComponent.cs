using BBS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBS.Web.Components
{
    public class LoginViewComponent:ViewComponent
    {
        /// <summary>
        /// 登录组件
        /// </summary>
        /// <returns></returns>
        public IViewComponentResult Invoke()
        {
            ViewBag.ReturnUrl = Request.Path.Value;
            return View(new AccountModel());
        }
    }
}
