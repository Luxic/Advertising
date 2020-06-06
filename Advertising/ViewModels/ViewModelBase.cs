using Advertising.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertising.ViewModels
{
	public abstract class ViewModelBase
	{
		public IEnumerable<MenuForm> MenuForms { get; set; }
	}
}
