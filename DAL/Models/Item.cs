using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace DAL.Models
{
	public class Item
	{
		[Key]
		[StringLength(128)]
		public string ItemCode { get; set; }
		[StringLength(254)]
		public string ItemName { get; set; }
		public bool Active { get; set; }
	}
}
