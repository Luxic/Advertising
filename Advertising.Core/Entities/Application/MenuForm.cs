using Advertising.Core.Interfaces;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Advertising.Core.Entities
{
	[Table("MenuForm")]
	public class MenuForm : BaseEntity, IAggregateRoot
	{
		public int DCFormId { get; private set; }
		public int? ParentID { get; private set; }
		public string Text { get; private set; }
		public int? Group { get; private set; }
		public int Order { get; private set; }
		public bool Active { get; private set; }

		public DCForm DCForm { get; private set; }
		public MenuForm Parent { get; private set; }

		public IEnumerable<MenuForm> childMenuForms { get; private set; }
	}
}
