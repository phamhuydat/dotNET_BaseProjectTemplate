using App.Data.Entities;
using App.Data.Repositories;
using App.Share.Consts;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Org.BouncyCastle.Asn1.X509;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.Components.MainNavBar
{
	public class MainNavBarViewComponent : ViewComponent
	{
		readonly GenericRepository repository;
		public MainNavBarViewComponent(GenericRepository _repository)
		{
			repository = _repository;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var navBar = new NavBarViewModel();
			navBar.Items.AddRange(new MenuItem[]
			{
				new MenuItem
				{
					Action = "Index",
					Controller = "User",
					DisplayText = "Quản lý tài khoản",
					Icon = "fa-user-cog",
					Permission = AuthConst.AppUser.VIEW_LIST,
				},
				new MenuItem
				{
					Action = "Index",
					Controller = "Role",
					DisplayText = "Quản lý phân quyền",
					Icon = "fa-user-shield",
					Permission = AuthConst.AppRole.VIEW_LIST,
				},
				new MenuItem
				{
					Action = "Index",
					Controller = "FileManager",
					DisplayText = "Quản lý tệp",
					Icon = "fa-folder-open",
				},
				new MenuItem
				{
                    Action = "Index",
                    Controller = "Category",
                    DisplayText = "Quản lý Danh mục",
                    Icon = "fas fa-layer-group",
                },
				// menu cap 2
				new MenuItem
				{
					DisplayText = "Menu 2 cấp",
					Icon = "fa-folder-open",
					ChildrenItems = new MenuItem[]
					{
						new MenuItem
						{
							Action = "Index",
							Controller = "User",
							DisplayText = "Quản lý tài khoản",
							Icon = "fa-user-cog"
						}
					}
				},
				//menu cap 3
                new MenuItem
                {
                    DisplayText = "Menu 3 cấp",
                    Icon = "fa-folder-open",
                    ChildrenItems = new MenuItem[]
                    {
                        new MenuItem
                        {
                            DisplayText = "Menu cap 2",
                            Icon = "fa-user-cog",

							ChildrenItems2 = new MenuItem[]
							{
								new MenuItem
								{
									Action = "Index",
									Controller = "User",
									DisplayText = "Menu cap 3",
									Icon = "fa-user-cog"

								},
							},
						},
                    }
                },
            });
			return View(navBar);
		}
	}
}
