using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Advertising.Core.Entities;
using Advertising.Interfaces;
using Advertising.ViewModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;

namespace Advertising.Controllers
{
	public class PropertyController : Controller
	{

		private readonly ILogger<PropertyController> _logger;
		private ICategoryViewModelService _categoryService;

		public PropertyController(ILogger<PropertyController> logger, ICategoryViewModelService categoryService, IApplicationService appService)
		{
			_logger = logger;
			_categoryService = categoryService;
		}

		// GET: Property
		public async Task<ActionResult> Index(int? categoryId)
		{
			var properties = await _categoryService.GetProperties(categoryId);
		 	return View(properties);
		}

		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Property/Create
		public async Task<ActionResult> Create()
		{
			IEnumerable<DataType> v = await _categoryService.GetDataTypes();

			IEnumerable<SelectListItem> items = v.Select(c => new SelectListItem
			{
				Value = c.ID.ToString(),
				Text = c.Name
			});

			ViewBag.DataType = v;
			return View();
		}

		// POST: Property/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(CategoryPropertyViewModel property)
		{
			try
			{

				_categoryService.AddCategoryProperty(property);

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Property/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Property/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}

		// GET: Property/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Property/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction(nameof(Index));
			}
			catch
			{
				return View();
			}
		}
	}
}