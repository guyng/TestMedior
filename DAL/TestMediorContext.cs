using System;
using System.Collections.Generic;
using System.Text;
using DAL.Enums;
using DAL.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace DAL
{
	public class TestMediorContext : ApiAuthorizationDbContext<ApplicationUser>
	{
		public TestMediorContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) :
			base(options, operationalStoreOptions)
		{
		}


		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			base.OnModelCreating(modelBuilder);
			modelBuilder.Entity<Hero>().HasData(
				new Hero()
				{
					Id = 1,
					StartingPower = 20,
					Ability = Ability.Attacker,
					Name = "Warrior",
					SuitColors = "Red,Blue",
					UserId = "32205d0b-cd03-4148-9027-dd353fb8af82"
				},
				new Hero()
				{
					Id = 2,
					StartingPower = 35.5M,
					Ability = Ability.Defender,
					Name = "Defender",
					SuitColors = "Red,Green",
					UserId = "32205d0b-cd03-4148-9027-dd353fb8af82"
				},
				new Hero()
				{
					Id = 3,
					StartingPower = 27,
					Ability = Ability.Attacker,
					Name = "Mage",
					SuitColors = "Yellow,Green",
					UserId = "32205d0b-cd03-4148-9027-dd353fb8af82"
				},
				new Hero()
				{
					Id = 4,
					StartingPower = 120,
					Ability = Ability.Defender,
					Name = "Templar",
					SuitColors = "Green,Blue",
					UserId = "32205d0b-cd03-4148-9027-dd353fb8af82"
				},
				new Hero()
				{
					Id = 5,
					StartingPower = 56,
					Ability = Ability.Attacker,
					Name = "Ninja",
					SuitColors = "Red,Blue",
					UserId = "a59359c6-a2ba-47f8-ae37-7868733ea1f4"
				},
				new Hero()
				{
					Id = 6,
					StartingPower = 44,
					Ability = Ability.Defender,
					Name = "Shroud",
					SuitColors = "Red,Green",
					UserId = "a59359c6-a2ba-47f8-ae37-7868733ea1f4"
				},
				new Hero()
				{
					Id = 7,
					StartingPower = 33,
					Ability = Ability.Attacker,
					Name = "Tfue",
					SuitColors = "Yellow,Green",
					UserId = "a59359c6-a2ba-47f8-ae37-7868733ea1f4"
				},
				new Hero()
				{
					Id = 8,
					StartingPower = 115,
					Ability = Ability.Defender,
					Name = "Nadeshot",
					SuitColors = "Green,Blue",
					UserId = "a59359c6-a2ba-47f8-ae37-7868733ea1f4"
				}
			);
		}
	}
}
