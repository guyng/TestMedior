using BL.Services;
using BL.Services.Interfaces;
using DAL;
using DAL.Models;
using TestMedior.Middlewares;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace TestMedior
{
	public class Startup
	{
		public Startup(IConfiguration configuration)
		{
			Configuration = configuration;
		}

		public IConfiguration Configuration { get; }

		// This method gets called by the runtime. Use this method to add services to the container.
		public void ConfigureServices(IServiceCollection services)
		{
			services.AddDbContext<TestMediorContext>(options =>
				options.UseSqlServer(
					Configuration.GetConnectionString("DefaultConnection")));

			services.AddDefaultIdentity<ApplicationUser>()
				.AddEntityFrameworkStores<TestMediorContext>();

			services.AddIdentityServer()
				.AddApiAuthorization<ApplicationUser, TestMediorContext>();

			services.AddAuthentication()
				.AddIdentityServerJwt();
			services.AddScoped(typeof(IRepository<>), typeof(GenericRepository<>));
			services.AddScoped<IUserService, UserService>();
			services.AddScoped<IHeroesManagementService, HeroesManagementService>();
			services.AddControllersWithViews();
			services.AddRazorPages();
			// In production, the Angular files will be served from this directory
			services.AddSpaStaticFiles(configuration =>
			{
				configuration.RootPath = "ClientApp/dist";
			});

			services.Configure<IdentityOptions>(options =>
			{
				// Default Password settings.
				options.Password.RequireDigit = true;
				options.Password.RequireLowercase = true;
				options.Password.RequireNonAlphanumeric = true;
				options.Password.RequireUppercase = true;
				options.Password.RequiredLength = 8;
				options.Password.RequiredUniqueChars = 1;
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
		//		app.UseDatabaseErrorPage();
			}
			else
			{
				app.UseExceptionHandler("/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseMiddleware<ErrorLoggingMiddleware>();
			app.UseMiddleware<RequestLoggingMiddleware>();
			app.UseHttpsRedirection();
			app.UseStaticFiles();
			if (!env.IsDevelopment())
			{
				app.UseSpaStaticFiles();
			}

			app.UseRouting();

			app.UseAuthentication();
			app.UseIdentityServer();
			app.UseAuthorization();
			app.UseEndpoints(endpoints =>
			{
				endpoints.MapControllerRoute(
					name: "default",
					pattern: "{controller}/{action=Index}/{id?}");
				endpoints.MapRazorPages();
			});

			//app.UseSpa(spa =>
			//{
			//	// To learn more about options for serving an Angular SPA from ASP.NET Core,
			//	// see https://go.microsoft.com/fwlink/?linkid=864501

			//	spa.Options.SourcePath = "ClientApp";

			//	if (env.IsDevelopment())
			//	{
			//		spa.UseProxyToSpaDevelopmentServer("http://localhost:4200");
			//		//spa.UseAngularCliServer(npmScript: "start");
			//	}
			//});
		}
	}
}
