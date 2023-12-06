using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBS.Web.Infrastructure
{
    public class UserModel
    {
        public int Id { get; set; }//用户id
        public string Account { get; set; }//用户账号
        public string NickName { get; set; }//用户昵称
        public string Avatar { get; set; }//用户头像
        public bool IsLogin { get; set; }//是否登录
    }
}
