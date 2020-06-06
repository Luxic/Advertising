using Advertising.Core.Interfaces;

namespace Advertising.Core.Entities.Advertising
{
	public class CategoryProperty :BaseEntity, IAggregateRoot
	{
		public int CategoryId { get; set; }
		public int PropertyId { get; set; }
	}
}
