using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Advertising.Core.Entities
{
	[Table("DCForm")]
	public class DCForm
	{
		int id;
		string name;
		int dcLinkId;
		bool active;

		DCLink dcLink;

		public int Id { get => id; set => id = value; }
		public string Name { get => name; set => name = value; }
		public int DCLinkId { get => dcLinkId; set => dcLinkId = value; }
		public bool Active { get => active; set => active = value; }
		public DCLink DCLink { get => dcLink; set => dcLink = value; }
	}
}
