using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using Microsoft.AspNetCore.Identity;

namespace DAL.Models
{
	public class User
	{
		[Key]
		public int Id { get; set; }
		[StringLength(1024)]
		public string FullName { get; set; }
		[StringLength(254)]
		public string UserName { get; set; }
		[StringLength(Int32.MaxValue)]
		public string Password { get; set; }
		public bool Active { get; set; }
	}
}
