using System;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataProject.Context;

namespace ODataProject.Controllers
{
	//[Route("api/students")]
	//[ApiController]
	public class StudentsController : ODataController //ControllerBase
    {
		private readonly MyDbContext _ctx;

		public StudentsController(MyDbContext ctx)
		{
			_ctx = ctx;
		}

		[EnableQuery]
		[HttpGet]
		public async Task<IActionResult> Get()
		{
			try
			{
				return await Task.Run(() => Ok(_ctx.Students));
			}
			catch (Exception)
			{
				throw;
			}
		}
    }
}