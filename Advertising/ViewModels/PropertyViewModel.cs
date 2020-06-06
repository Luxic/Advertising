using Advertising.Core.Entities;

namespace Advertising.ViewModels
{
	public class PropertyViewModel
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public int DataTypeId { get; set; }
		public DataType DataType { get; set; }
		public string Description { get; set; }
	}
}
