using Advertising.Interfaces;
using Advertising.Models;
using Advertising.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Advertising.Controllers
{
	public class HomeController : Controller
	{
		private readonly ILogger<HomeController> _logger;
		private ICategoryViewModelService _categoryService;
		private IApplicationService _appService;

		public HomeController(ILogger<HomeController> logger, ICategoryViewModelService categoryService, IApplicationService appService)
		{
			_logger = logger;
			_categoryService = categoryService;
			_appService = appService;
		}

		public async Task<IActionResult> Index(int? id)
		{
			CategoryIndexViewModel categoryModel;
			
			categoryModel = await _categoryService.GetCategories(id); 

			return View(categoryModel);
		}

		public async Task<IActionResult> Edit(int id)
		{
			CategoryViewModel categoryModel = await _categoryService.GetCategory(id);

			return View(categoryModel);
		}

		//public async Task<IActionResult> Edit(CategoryViewModel entity)
		//{
		//	return View();
		//}

		public ActionResult Create()
		{
			return View();
		}

		public ActionResult Delete(int categoryId)
		{
			_categoryService.DeleteCategory(categoryId);
			return View("Index", _categoryService.GetCategories(null).Result);
		}

		// POST: Category/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(CategoryViewModel category)
		{
			try
			{
				_categoryService.AddCategory(category);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		public IActionResult Privacy()
		{
			return View();
		}

		[ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
		public IActionResult Error()
		{
			return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
		}
	}
}
