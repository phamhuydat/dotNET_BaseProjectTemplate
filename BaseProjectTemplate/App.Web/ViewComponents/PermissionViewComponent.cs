﻿using App.Data.Entities;
using App.Data.Repositories;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using X.PagedList;

namespace App.Web.ViewComponents
{
	public class PermissionViewComponent : ViewComponent
	{
		readonly RepositoryBase repository;
		public PermissionViewComponent(RepositoryBase _repository)
		{
			this.repository = _repository;
		}
		public async Task<IViewComponentResult> InvokeAsync()
		{
			var data = await repository
							.GetAllMst<MstPermission>()
							.AsEnumerable()
							.GroupBy(x => x.Groupname)
							.ToListAsync();
			return View(data);
		}
	}
}
