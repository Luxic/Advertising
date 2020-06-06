using System.Collections.Generic;

namespace Advertising.ViewModels
{
	public class CategoryViewModel
	{
		public int Id { get; set; }
		public int? ParrentCategoryId { get; set; }
		public string Name { get; set; }
		public List<CategoryViewModel> SubCategoriesList { get; set; } = new List<CategoryViewModel>();
	}
}
