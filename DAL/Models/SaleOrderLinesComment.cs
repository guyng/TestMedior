using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace DAL.Models
{
	public class SaleOrderLinesComment
	{
		[Key]
		public int CommentLineID { get; set; }
		[ForeignKey("SaleOrder")]
		public int DocID { get; set; }
		[ForeignKey("SaleOrderLine")]
		public int LineID { get; set; }

		public virtual SaleOrder SaleOrder { get; set; }
		public virtual SaleOrderLine SaleOrderLine { get; set; }
		public string Comment { get; set; }

	}
}
