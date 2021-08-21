using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
	public class SaleOrder
	{
		[Key]
		public int Id { get; set; }
		[ForeignKey("BusinessPartner")]
		public string BPCode { get; set; }
		public virtual BusinessPartner BusinessPartner { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime LastUpdateDate { get; set; }
		[ForeignKey("User")]
		public int CreatedBy { get; set; }
		[ForeignKey("User")]
		public int? LastUpdatedBy { get; set; }
		public virtual User User { get; set; }

	}
}
