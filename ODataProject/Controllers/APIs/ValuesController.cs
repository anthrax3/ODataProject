using System;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataProject.Context;

namespace ODataProject.Controllers.APIs
{
	[Route("api/values")]
	[ApiController]
	public class ValuesController : ControllerBase
	{
		private readonly MyDbContext _ctx;

		public ValuesController(MyDbContext ctx)
		{
			_ctx = ctx;
		}

		[EnableQuery]
		[HttpGet]
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