using System.Collections.Generic;

namespace Advertising.ViewModels
{
	public class PropertyIndexViewModel
	{
		public CategoryViewModel Category { get; set; }
		public IEnumerable<PropertyViewModel> properties { get; set; }
	}
}
