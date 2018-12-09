﻿using MusicStoreEntity.UserAndRole;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MusicStoreEntity
{
   public  class Order
    {

        [ScaffoldColumn(false)]
        public Guid ID { get; set; }


        [ScaffoldColumn(false)]
        public DateTime OrderDateTime { get; set; }//订单的时间

        [ScaffoldColumn(false)]
        public virtual Person Person { get; set; }//所属用户

        [Display(Name ="收件人")]
        [Required(ErrorMessage = "收件人不能为空")]
        public string AddressPerson { get; set; }// 收件人
        public string Address { get; set; }// 收件人地址
        [Display(Name = "收件人地址")]
        [Required(ErrorMessage = "收件人地址不能为空")]
        public string  MobilNumber{ get; set; }//收件人电话号码

        [Display(Name = "收件人电话号码")]
        [Required(ErrorMessage = "收件人号码不能为空")]


        [ScaffoldColumn(false)]
        public decimal TotalPrice { get; set; }//总价

        [ScaffoldColumn(false)]
        public string TradeNo { get; set; }//支付宝流水号

        [ScaffoldColumn(false)]
        public bool PaySuccess { get; set; }//是否支付成功

        [ScaffoldColumn(false)]
        public virtual EnumOrderStatus EnumOrderStatus { get; set; } //订单的状态

        //购买专辑明细,EF中包含关系
        public virtual ICollection<OrderDetail> OrderDetails  { get; set; }
        public Order()
        {
            ID = Guid.NewGuid();
            OrderDateTime = DateTime.Now;
            TradeNo = OrderDateTime.ToString("yyyyMMddhhmmssffff");
        }
    }
}
