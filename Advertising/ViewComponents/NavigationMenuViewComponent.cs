using Advertising.Core.Interfaces;
using Advertising.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Advertising.ViewComponents
{
	public class NavigationMenuViewComponent : ViewComponent
	{
		IMenuFormRepository _menuFormRepository;
		
		public NavigationMenuViewComponent(IMenuFormRepository menuFormRepository)
		{
			_menuFormRepository = menuFormRepository;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var menus = await _menuFormRepository.GetAll(); //(HttpContext.User);

			
				var menuFormIndexViewModel = new MenuFormIndexViewModel()
				{
					MenuFormViewModel = menus.Select(i => new MenuFormViewModel()
					{
						id = i.Id,
						parrentId = i.ParentID,
						text = i.Text,
						controller = i.DCForm.DCLink.Controller,
						action = i.DCForm.DCLink.Action,
					}).ToList(),
				};

				menuFormIndexViewModel.menuFormRoot = new MenuFormViewModel();
				menuFormIndexViewModel.menuFormRoot.id = 0;
				menuFormIndexViewModel.SetChildeForms();

				return await Task.FromResult((IViewComponentResult)View("Default", menuFormIndexViewModel));			
		}
	}
}
