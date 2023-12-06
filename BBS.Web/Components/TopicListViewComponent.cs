using BBS.Framework.Models;
using BBS.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBS.Web.Components
{
    public class TopicListViewComponent : ViewComponent
    {
        /// <summary>
        /// 主题列表
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public IViewComponentResult Invoke(PagedList<TopicModel> model)
        {
            return View(model); 
        }
    }
}
