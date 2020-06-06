using Advertising.Core.Entities;
using Advertising.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertising.Interfaces
{
	public interface ICategoryViewModelService
	{
		Task<CategoryIndexViewModel> GetCategories(int? parrentId);
		Task<IEnumerable<PostViewModel>> GetPosts(int? CategoryId, int pageIndex, int itemsPage);
		void AddCategory(CategoryViewModel category);
		Task<CategoryViewModel> GetCategory(int id);
		void DeleteCategory(int id);
		Task<PropertyIndexViewModel> GetProperties(int? categoryId);
		Task<IEnumerable<DataType>> GetDataTypes();
		void AddCategoryProperty(CategoryPropertyViewModel property);
	}
}
