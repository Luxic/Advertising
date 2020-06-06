using Advertising.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Advertising.Core.Entities.Advertising
{
	[Table("Property")]
	public class Property : BaseEntity, IAggregateRoot
	{
		public string Name { get; set; }
		public DataType DataType { get; set; }
		public string Description { get; set; }
	}
}
