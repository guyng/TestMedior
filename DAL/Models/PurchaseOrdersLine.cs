using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
	public class PurchaseOrdersLine
	{
		public int LineID { get; set; }
		public int DocID { get; set; }
		public string ItemCode { get; set; }
		public int Quantity { get; set; }
		public DateTime CreateDate { get; set; }
		public DateTime LastUpdateDate { get; set; }
		[ForeignKey("User")]
		public int CreatedBy { get; set; }
		[ForeignKey("User")]
		public int? LastUpdatedBy { get; set; }
		public virtual User User { get; set; }
	}
}
