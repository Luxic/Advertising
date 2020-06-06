using Advertising.Core.Entities;
using Advertising.Core.Entities.Advertising;
using Advertising.Core.Interfaces;
using Advertising.Interfaces;
using Advertising.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Advertising.Services
{
	public class CategoryViewModelService : ICategoryViewModelService
	{
		private readonly ICategoryRepository _categoryRepository;
		private readonly IPropertyRepository _propertyRepository;

		public CategoryViewModelService(ICategoryRepository categoryInterface, IPropertyRepository propertyRepository)
		{
			_categoryRepository = categoryInterface;
			_propertyRepository = propertyRepository;
		}

		public void AddCategory(CategoryViewModel category)
		{
			try
			{
				var newCategory = new Category()
				{
					ParrentCategoryId = category.ParrentCategoryId,
					Name = category.Name
				};

				_categoryRepository.AddAsync(newCategory);
			}
			catch (Exception ex)
			{ }
		}

		public void AddCategoryProperty(CategoryPropertyViewModel property)
		{


			var newCategory = new CategoryProperty()
			{
				CategoryId = property.CategoryId,
				PropertyId = property.PropertyId
			};

			_propertyRepository.AddProperty(newCategory);
		}

		public void DeleteCategory(int id)
		{
			Category entity = _categoryRepository.GetByIdAsync(id).Result;
			_categoryRepository.DeleteAsync(entity);
		}

		public async Task<CategoryIndexViewModel> GetCategories(int? parrentId)
		{
			var ret = await _categoryRepository.GetByParrentId(parrentId);

			var list = new CategoryIndexViewModel()
			{
				Categories = ret.Select(i => new CategoryViewModel()
				{
					Id = i.Id,
					ParrentCategoryId = i.ParrentCategoryId,
					Name = i.Name
				}),
			};

			return list;
		}

		public async Task<CategoryViewModel> GetCategory(int CategoryId)
		{
			var ret = await _categoryRepository.GetByIdAsync(CategoryId);
			var subcategories = await _categoryRepository.GetByParrentId(CategoryId);

			var category = new CategoryViewModel()
			{
				Id = ret.Id,
				ParrentCategoryId = ret.ParrentCategoryId,
				Name = ret.Name,
				SubCategoriesList = subcategories.Select(i => new CategoryViewModel()
				{
					Id = i.Id,
					ParrentCategoryId = i.ParrentCategoryId,
					Name = i.Name
				}).ToList(),
			};

			return category;
		}

		public async Task<IEnumerable<DataType>> GetDataTypes()
		{
			return await _categoryRepository.GetDataTypes();
		}

		public Task<IEnumerable<PostViewModel>> GetPosts(int? CategoryId, int pageIndex, int itemsPage)
		{
			throw new NotImplementedException();
		}

		public async Task<PropertyIndexViewModel> GetProperties(int? categoryId)
		{
			var ret = await _propertyRepository.GetByCategoryId(categoryId);

			var list = new PropertyIndexViewModel()
			{
				properties = ret.Select(i => new PropertyViewModel()
				{
					Id = i.Id,
					Name = i.Name,
					Description = i.Description,
					DataType = i.DataType
				}),
			};

			return list;
		}
	}
}
