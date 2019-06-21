using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNet.OData.Query;
using Microsoft.AspNetCore.Mvc;
using ODataProject.Context;

namespace ODataProject.Controllers
{
	// [Route("api/schools")]
    // [ApiController]
    public class SchoolsController : ODataController //ControllerBase
    {
		private readonly MyDbContext _ctx;

		public SchoolsController(MyDbContext ctx)
		{
			_ctx = ctx;
		}

		[EnableQuery]
		[HttpGet]
		public async Task<IQueryable> Get()
		{
			try
			{
				return await Task.Run(() => _ctx.Schools);
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}