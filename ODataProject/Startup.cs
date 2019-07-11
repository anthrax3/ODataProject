using System.Linq;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OData.Edm;
using ODataProject.Extensions;
using ODataProject.Models;

namespace ODataProject
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
			services.AddAllConfiguration(Configuration);
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
			{
				app.UseDeveloperExceptionPage();
			}
			else
			{
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();

			app.UseCors("myCors");

			var builder = new ODataConventionModelBuilder();
			builder.EntitySet<Student>("Students");
			builder.EntitySet<School>("Schools");

			app.UseMvc(routeBuilder =>
			{
				routeBuilder.Expand().Select().Count(QueryOptionSetting.Allowed).Filter().OrderBy().MaxTop(100);
				routeBuilder.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
				routeBuilder.EnableDependencyInjection();
			});
		}
	}
}
