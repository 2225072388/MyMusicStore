using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo1.Controllers
{
    public class HelloWorldController : Controller
    {
        // GET: HelloWorld
        public ActionResult lndex() {
            return View("../../Views/Test/Test1");
            //return View();
        }
        //public string Index()
        //{
        //    return "这是我的<b>默认</b>控制器方法（action）";
        //}

        //public string Welcome(string name, int numtimes = 1)
        //{
        //    name = "小明";
        //    numtimes = 4;
        //    return "您好," + name + ",欢迎次数：" + numtimes + "次";
        //}
        public ActionResult Welcome(string name, int id = 1)
        {
            ViewBag.ID = id;
            ViewBag.Name = name+ ",您好！";
            Session["message"] = "今天阴天又下雨";
            return View();
        }
    }
}