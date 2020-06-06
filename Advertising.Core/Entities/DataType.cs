using Advertising.Core.Interfaces;
using System.ComponentModel.DataAnnotations.Schema;

namespace Advertising.Core.Entities
{
	[Table("DCDataType")]
	public class DataType /*: BaseEntity, IAggregateRoot*/
	{
		public int ID { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
	}
}
