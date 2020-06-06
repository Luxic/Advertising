using Advertising.Core.Interfaces;
using Advertising.Interfaces;
using Advertising.ViewModels;
using System.Threading.Tasks;
using System;
using System.Collections.Generic;
using System.Linq;
using Advertising.Core.Entities;

namespace Advertising.Services
{
	public class ApplicationService : IApplicationService
	{
		IMenuFormRepository _menuFormRepository;

		public ApplicationService(IMenuFormRepository menuFormRepository)
		{
			_menuFormRepository = menuFormRepository;
		}

		public async Task<MenuFormIndexViewModel> GetMenus(int userId)
		{
			var menus = await _menuFormRepository.GetAll();

			var menuFormIndexViewModel = new MenuFormIndexViewModel();
			 
			return menuFormIndexViewModel;
		}
	}
}
