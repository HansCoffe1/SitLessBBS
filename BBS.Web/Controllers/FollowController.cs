using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BBS.Domain;
using BBS.Framework.Extensions;
using BBS.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BBS.Web.Controllers
{
    public class FollowController : BBSController
    {
        private readonly BBSDbContext _context;
        public FollowController(BBSDbContext context)
        {
            _context = context;
        }
        /// <summary>
        /// 关注列表
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Add(int id)
        {
            try
            {
                if (id == UserModel.Id) return Json(false.ToResult("不能关注自己"));

                var entity = new Follow { FollowAccountId = id };
                entity.AccountId = UserModel.Id;
                entity.CreateTime = DateTime.Now;
                _context.Follow.Add(entity);
                _context.SaveChanges();
                return Json(true.ToResult());
            }
            catch (DbUpdateException ex)
            {
                return Json(false.ToResult("请勿重复操作"));
            }
            catch (Exception ex)
            {
                return Json(false.ToResult("未知错误，请联系管理人员"));
            }
        }
        /// <summary>
        /// 取消关注
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        [HttpPost]
        public IActionResult Delete(int id)
        {
            var entity = _context.Follow.FirstOrDefault(x => x.FollowAccountId == id && x.AccountId == UserModel.Id);
            if (entity != null)
            {
                _context.Follow.Remove(entity);
                _context.SaveChanges();
            }
            return Json(true.ToResult());
        }
    }
}