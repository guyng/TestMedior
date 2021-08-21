using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
	public class BPType
	{
		[Key]
		[StringLength(1)]
		public string TypeCode { get; set; }
		[StringLength(20)]
		public string TypeName { get; set; }
	}
}
