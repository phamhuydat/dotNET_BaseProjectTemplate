﻿using App.Web.ViewModels;
using App.Web.ViewModels.User;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Controllers
{
	public class AppControllerBase : Controller
	{
		protected const int DEFAULT_PAGE_SIZE = 15;
		protected const string EXCEPTION_ERR_MESG = "Đã xảy ra lỗi trong quá trình xử lý dữ liệu (500)";
		protected const string MODEL_STATE_INVALID_MESG = "Dữ liệu không hợp lệ, vui lòng kiểm tra lại";

		protected readonly IMapper mapper;
		protected int CurrentUserId { get => Convert.ToInt32(HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)); }
		protected string CurrentUsername { get => HttpContext.User.Identity.Name; }
		
		public AppControllerBase(IMapper _mapper)
		{
			mapper = _mapper;
		}

		protected RedirectToActionResult HomePage() => RedirectToAction("Index", "Home");

		protected void SetErrorMesg(string mesg) => TempData["Err"] = mesg;

		protected void SetSuccessMesg(string mesg) => TempData["Success"] = mesg;

		protected void LogExceptionToConsole(Exception ex)
		{
			Console.WriteLine("\n--- EXCEPTION ---");
			Console.WriteLine(ex.Message);
			Console.WriteLine(ex.InnerException);
			Console.WriteLine(ex.StackTrace);
			SetErrorMesg(EXCEPTION_ERR_MESG);
		}

		protected void HashHMACSHA512(UserAddOrEditVM user)
		{
			HMACSHA512 hmac = new();
			var pwByte = Encoding.UTF8.GetBytes(user.Password);
			user.PasswordHash = hmac.ComputeHash(pwByte);
			user.PasswordSalt = hmac.Key;
		}

		protected byte[] HashHMACSHA512WithKey(string pwd, byte[] key)
		{
			HMACSHA512 hmac = new(key);
			var pwdByte = Encoding.UTF8.GetBytes(pwd);
			return hmac.ComputeHash(pwdByte);
		}
	}
}
