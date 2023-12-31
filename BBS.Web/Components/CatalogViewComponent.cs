﻿using BBS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBS.Web.Components
{
    public class CatalogViewComponent : ViewComponent
    {
        /// <summary>
        /// 分类列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(CatalogModel model)
        {
            return View(model);
        }
    }
}
