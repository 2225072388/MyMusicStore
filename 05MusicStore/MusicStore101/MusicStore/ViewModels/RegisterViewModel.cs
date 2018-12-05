﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MusicStore.ViewModels
{
    /// <summary>
    /// 注册的视图模型
    /// </summary>
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="用户名不能为空")]
        [Display(Name ="登录名")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "姓名不能为空")]
        [Display(Name = "姓名")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "用户名不能为空")]
        [Display(Name = "登录名")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required(ErrorMessage = "密码不能为空")]
        [Display(Name = "密码")]
        [DataType(DataType.Password)]
        [StringLength(20,ErrorMessage ="{0}密码长度不能短于6位",MinimumLength =6)]
        public string PassWord { get; set; }

        
        [Display(Name = "确认密码")]
        [DataType(DataType.Password)]
        [StringLength(20, ErrorMessage = "{0}密码长度不能短于6位", MinimumLength = 6)]
        public string ConfirmPassWord { get; set; }


    }
}