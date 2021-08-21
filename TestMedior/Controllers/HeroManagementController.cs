using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BL.Services;
using BL.Services.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Task = DAL.Models.Task;

namespace TestMedior.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	[Authorize]
	public class HeroManagementController : ControllerBase
	{
		private readonly IHeroesManagementService _heroesManagementService;

		public HeroManagementController(IHeroesManagementService heroesManagementService)
		{
			_heroesManagementService = heroesManagementService;
		}

		[HttpGet]
		public async Task<IActionResult> GetAllHeroes()
		{
			try
			{
				var tasks = await _heroesManagementService.GetAllHeroes();
				return Ok(tasks);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}

		}

		[HttpGet("[action]")]
		public async Task<IActionResult> GetUserHeroes()
		{
			try
			{
				var tasks = await _heroesManagementService.GetUserHeroes();
				return Ok(tasks);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}

		}

		[HttpPut("{heroId}")]
		public async Task<IActionResult> TrainHero(int heroId)
		{
			try
			{
				var trainedHero = await _heroesManagementService.TrainHero(heroId);
				if (trainedHero == null)
				{
					return BadRequest();
				}
				return Ok(trainedHero);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}

		}
	}
}
