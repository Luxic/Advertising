using Advertising.Core.Entities;
using System.Collections.Generic;
using System.Linq;

namespace Advertising.ViewModels
{
	public class MenuFormViewModel : ViewModelBase
	{
		public int id;
		public int? formId;
		public int? parrentId;
		public string text;
		public int? group;
		public int? order;
		public bool active;
		public string controller;
		public string action;
	}
}
