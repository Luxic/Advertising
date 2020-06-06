using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Advertising.Core.Entities
{
	[Table("DCLink")]
	public class DCLink
	{
		int id;
		string controller;
		string action;
		string name;
		string description;
		DateTime dateCreated;
		bool active;

		public string Controller { get => controller; set => controller = value; }
		public string Action { get => action; set => action = value; }
		public string Name { get => name; set => name = value; }
		public string Description { get => description; set => description = value; }
		public DateTime DateCreated { get => dateCreated; set => dateCreated = value; }
		public bool Active { get => active; set => active = value; }
		public int ID { get => id; set => id = value; }
	}
}
