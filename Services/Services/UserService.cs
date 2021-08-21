using System;
using System.Collections.Generic;
using System.Security.Claims;
using System.Text;
using Microsoft.AspNetCore.Http;


namespace BL.Services
{
	public class UserService : IUserService
	{
		private readonly IHttpContextAccessor _httpContextAccessor;

		public UserService(IHttpContextAccessor httpContextAccessor)
		{
			_httpContextAccessor = httpContextAccessor;
		}
		public string GetUserId()
		{
			var userId = _httpContextAccessor.HttpContext.User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
			return userId;
		}
	}
}
