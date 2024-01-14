using App.Data.Repositories;
using App.Share.Consts;
using App.Web.Common;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using App.Data.Entities;
using Microsoft.EntityFrameworkCore;
using App.Data;
using System.Linq;
using AutoMapper.QueryableExtensions;
using App.Web.ViewModels.Category;
using App.Web.WebConfig;
using System.Threading.Tasks;

namespace App.Web.Controllers
{
	public class CategoryController : AppControllerBase
	{
		readonly GenericRepository _repository;

        public CategoryController(GenericRepository repository, IMapper mapper) : base(mapper)
        {
			_repository = repository;
		}
		[AppAuthorize(AuthConst.AppCategory.VIEW)]
        public IActionResult Index()
		{
			var data = _repository
					.GetAll<AppCategory, CategoryListItemVM>(AutoMapperProfile.CategoryIndexConf)
					.ToList();
            return View(data);
		}
		[AppAuthorize(AuthConst.AppCategory.CREATE)]
		[HttpGet]
		public IActionResult Create() 
		{
			return View();
		}
		[HttpPost]
        public async Task<IActionResult> Create(CategoryAddEditVM model) 
		{
			var category = _mapper.Map<AppCategory>(model);

			await _repository.AddAsync(category);

			return RedirectToAction(nameof(Index));
		}

		// edit information category
		public async Task<IActionResult> Update(int id)
		{
			var data = await _repository.FindAsync<AppCategory>(id);
			var VM = _mapper.Map<CategoryAddEditVM>(data);
			return View(nameof(Create), VM);
		}
		
    }
}
