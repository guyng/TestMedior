using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
	public class SaleOrderLine
	{
		[Key]
		public int LineID { get; set; }
		[ForeignKey("SaleOrder")]
		public int DocID { get; set; }
		[ForeignKey("BusinessPartner")]
		[StringLength(128)]
		public string ItemCode { get; set; }
		public virtual BusinessPartner BusinessPartner { get; set; }
		[Column(TypeName = "decimal(38, 18)")]
		public int Quantity { get; set; }
		[ForeignKey("User")]
		public int CreatedBy { get; set; }
		[ForeignKey("User")]
		public int? LastUpdatedBy { get; set; }
		public virtual User User { get; set; }
		public DateTime? LastUpdateDate { get; set; }
	}
}
