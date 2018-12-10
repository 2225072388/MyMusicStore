﻿using MusicStore.ViewMoldels;
using MusicStoreEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MusicStore.Controllers
{
    

    public class OrderController : Controller
    {
     private static readonly EntityDbContext _context = new EntityDbContext();

        /// <summary>
        /// 下单页
        /// </summary>
        /// <returns></returns>

        public ActionResult Buy()
        {
            //确认用户是否登录 是否登录过期
            if (Session["loginUserSessionModel"] == null)
                return RedirectToAction("login", "Account", new { returnUrl = Url.Action("Buy", "Order") });
           
            //查询出当前用户Person 查询该用户的购物项
            var person = (Session["LoginUserSessionModel"] as LoginUserSessionModel).Person;
            var carts = _context.Carts.Where(x => x.Person.ID == x.Person.ID).ToList();

            //购物车总价
            decimal? totalPrice = (from item in carts select item.Count * item.Album.Price).Sum();

            //创建新 order 对象
            var order = new Order()
            {
                AddressPerson = person.Name,
                MobilNumber = person.MobileNumber,
                Person = _context.Persons.Find(person.ID ),
                TotalPrice =totalPrice??0.00M,
            };

            //把购物车项导入明细
            order.OrderDetails = new List<OrderDetail>();
            foreach (var item in carts)
            {
                var detail = new OrderDetail()
                {
                    AlbumID = item.AlbumID,
                    Album = _context.Albums.Find(item.Album.ID),
                    Count = item.Count,
                    Price =item .Album.Price
                };
                order.OrderDetails.Add(detail);
            }

            //将订单、明细在视图呈现，验证用户收件人、地址、电话、供用户选择确认购买专辑
            //
            Session["Order"] = order;
            return View(order);
            

        }
        [HttpPost]
        public ActionResult RemoveDetail(Guid id)
        {
            return Json ("");
        }



        /// <summary>
        /// 处理提交下单
        /// </summary>
        /// <param name="order"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Buy(Order order)
        {
            return View();
        }




        /// <summary>
        /// 浏览用户订单
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}