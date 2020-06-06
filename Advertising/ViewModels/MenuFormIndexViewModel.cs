using System;
using System.Collections.Generic;
using System.Linq;

namespace Advertising.ViewModels
{
	public class MenuFormIndexViewModel
	{
		public MenuFormViewModel menuFormRoot { get; set; }
		public List<MenuFormViewModel> MenuFormViewModel { get; set; }

		internal void SetChildeForms()
		{
			foreach(MenuFormViewModel v in MenuFormViewModel.Where(x =>x.parrentId == null))
			{
				v.parrentId = menuFormRoot.id;
			}
		}
	}
}
