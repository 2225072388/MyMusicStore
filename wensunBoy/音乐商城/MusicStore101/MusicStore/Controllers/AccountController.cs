using MusicStoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    public class AccountController : Controller
    {
        private static readonly EntityDbContext _context = new EntityDbContext();
        // GET: Account
        /// <summary>
        /// 用户信息 登入和注册
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public ActionResult login(Guid id)
        {
            var detail = _context.Albums.Find(id);
            return View(detail);
        }
        //public ActionResult Register()
        //{
        //    var detail = _context.Albums.Find(id);
        //    return View(detail);
        //}
    }
}