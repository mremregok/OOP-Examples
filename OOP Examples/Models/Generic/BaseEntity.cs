using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Examples.Models.Generic
{
	public class BaseEntity
	{
		public int Id { get; set; }
		public string Description { get; set; }
		public string Type { get; set; }
		public string TypeDescription { get; set; }
		public DateTime CreatedDate { get; set; }
		public DateTime UpdatedDate { get; set; }
	}
}
