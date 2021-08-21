using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
	public class BusinessPartner
	{
		[Key]
		[StringLength(128)]
		public string BPCode { get; set; }
		[StringLength(254)]
		public string BPName { get; set; }
		[StringLength(1)]
		[ForeignKey("BPType")]
		public string BPType { get; set; }
		public virtual BPType BpType { get; set; }
		public bool Active { get; set; }
	}
}
