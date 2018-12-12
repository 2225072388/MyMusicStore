﻿using MusicStore.ViewModels;
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
            //1.确认用户是否登录  是否登录过期
            if (Session["LoginUserSessionModel"] == null)
                return RedirectToAction("login", "Account", new { returnUrl = Url.Action("Buy", "Order") });

            //2.查询出当前用户Person  查询该用户的购物项
            var person = (Session["LoginUserSessionModel"] as LoginUserSessionModel).Person;
            var carts = _context.Carts.Where(x => x.Person.ID == x.Person.ID).ToList();
            //算购物车的总价
            decimal? totalPrice = (from item in carts select item.Count * item.Album.Price).Sum();  //linq表达式 一句完成

            //3.创建新Order对象
            var order = new Order()
            {
                AddressPerson = person.Name,
                MobilNumber = person.MobileNumber,
                Person = _context.Persons.Find(person.ID),
                TotalPrice = totalPrice ?? 0.00M,
            };

            //4.把购物项导入订单明细
            order.OrderDetails = new List<OrderDetail>();
            foreach (var item in carts)
            {
                var detail = new OrderDetail()
                {
                    AlbumID = item.AlbumID,
                    Album = _context.Albums.Find(item.Album.ID),
                    Count = item.Count,
                    Price = item.Album.Price
                };
                order.OrderDetails.Add(detail);
            }

            //将订单和明细在视图呈现, 验证用户收件人、地址、电话，供用户选择确认要购买专辑

            //当前订单未持久化，用会话保存方便用户进行编辑
            Session["Order"] = order;
            return View(order);
        }

        [HttpPost]
        public ActionResult RemoveDetail(Guid id)
        {
            //如果会话为空 则重新刷新页面
            if (Session["Order"] == null)
                return RedirectToAction("buy");

            //读取会话中的Order对象
            var order = Session["Order"] as Order;
            var deletaDetail = order.OrderDetails.SingleOrDefault(x => x.ID == id);

            //从订单明细列表中移除明细记录
            order.OrderDetails.Remove(deletaDetail);


            //根据新的order对象重新生成Html脚本 返回ison数据 局部刷新视图
            var htmlString = "";
            //订单总价
            var totalPrice = (from item in order.OrderDetails select item.Count * item.Album.Price).Sum();
            foreach (var item in order.OrderDetails)
            {
                htmlString += "<tr>";
                htmlString += "<td><a href='" + Url.Action("Detail", "Store", new {id = item.Album.ID }) + "'>"
                    + item.Album.Title + "</a></td>";
                htmlString += "<td>" + item.Album.Price.ToString("C") + "</td>";
                htmlString += "<td>" + item.Count+"</td>";
                htmlString += "<td><a href='#' onclick=RemoveDetail("+item.ID+");'><i class='glyphicon-remove'></i>我不要它了</a></td>";
                htmlString += "</tr>";

            }
            htmlString += "<tr><td></td><td></td><td>总价</td><td>" + order.TotalPrice.ToString("C") + "</td></tr>";

            return Json(htmlString);
        }

        /// <summary>
        /// 处理用户提交下单
        /// </summary>
        /// <param name="oder"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult Buy(Order oder)
        {
            //
            return View();
        }

        /// <summary>
        /// 浏览用户订单列表
        /// </summary>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }
    }
}

    