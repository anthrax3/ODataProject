﻿using System;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using ODataProject.Context;

namespace ODataProject.Extensions
{
	public static class ExtensionMethods
	{

		public static void AddAllConfiguration(
			this IServiceCollection services,
			IConfiguration config)
		{
			services.AddCors(p => {
				p.AddPolicy("myCors", x => {
					x.AllowAnyMethod().AllowAnyHeader().AllowAnyOrigin();
				});
			});
			services
				.AddMvc(p => p.EnableEndpointRouting = false)
				.SetCompatibilityVersion(CompatibilityVersion.Version_2_2)
				.AddJsonOptions(options =>
					options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore);
			
			services.AddDbContext<MyDbContext>(options =>
			{
				options.UseSqlServer(
					config.GetConnectionString("DefaultConnection"),
					sqlServerOptionsAction: sqlOptions =>
					{
						sqlOptions.EnableRetryOnFailure(
							maxRetryCount: 10,
							maxRetryDelay: TimeSpan.FromSeconds(30),
							errorNumbersToAdd: null
						);
					});
			});

			services.AddOData();
		}

	}
}
