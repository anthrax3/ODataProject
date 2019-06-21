using System;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using ODataProject.Context;

namespace ODataProject.Controllers
{
	[Route("api/[controller]")]
    [ApiController]
    public class SchoolsController : ControllerBase
    {
		private readonly MyDbContext _ctx;

		public SchoolsController(MyDbContext ctx)
		{
			_ctx = ctx;
		}

		[EnableQuery(PageSize = 1000, AllowedQueryOptions = AllowedQueryOptions.All)]
		public async Task<IActionResult> Get()
		{
			try
			{
				return await Task.Run(() => Ok(_ctx.Schools));
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}