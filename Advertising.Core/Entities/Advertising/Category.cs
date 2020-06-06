using Advertising.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Advertising.Core.Entities.Advertising
{
	[Table("Category")]
	public class Category : BaseEntity, IAggregateRoot
	{
		public int? ParrentCategoryId { get; set; }
		public string Name { get; set; }
		public Category ParrentCategory { get; set; }
	}
}
