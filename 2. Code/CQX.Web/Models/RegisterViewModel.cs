﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CQX.Web.Models
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage = "用户名不能为空")]
        [Display(Name = "用户名")]
        public string UserName { get; set; }

        [Required(ErrorMessage = "密码不能为空")]
        [DataType(DataType.Password)]
        [Display(Name = "密码")]
        public string Password { get; set; }

        [Compare("Password")]
        [DataType(DataType.Password)]
        [Display(Name = "确认密码")]
        public string ConfirmPassword { get; set; }

        [Required(ErrorMessage="邮箱不能为空")]
        [EmailAddress(ErrorMessage="邮箱格式不正确")]
        [Display(Name = "电子邮箱")]
        public string Email { get; set; }
    }
}