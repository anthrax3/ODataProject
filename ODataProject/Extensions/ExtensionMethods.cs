using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ODataProject.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ODataProject.Extensions
{
	public static class ExtensionMethods
	{

		public static void AddAllConfiguration(
			this IServiceCollection services,
			IConfiguration config)
		{
			services.AddDbContext<MyDbContext>(options =>
			{
				//options.UseLazyLoadingProxies(false);
				options.UseSqlServer(config.GetConnectionString("DefaultConnection"));
			});

			services.AddOData();

			services.AddMvc()
				.SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
				.AddJsonOptions(options =>
					options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
		}

	}
}
