using System;
using System.Threading.Tasks;
using Microsoft.AspNet.OData;
using Microsoft.AspNetCore.Mvc;
using ODataProject.Context;
using ODataProject.Models;

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

		[HttpGet]
		public async Task<IActionResult> GetById(Guid id)
		{
			try
			{
				var school = await _ctx.Schools.FindAsync(id);

				if(school == null)
				{
					return NotFound();
				}

				return Ok(school);
			}
			catch (Exception)
			{
				throw;
			}
		}

		[HttpPost]
		public async Task<IActionResult> Post(School school)
		{
			try
			{
				_ctx.Add(school);
				await _ctx.SaveChangesAsync();
				return CreatedAtAction(nameof(GetById), new { id = school.SchoolId }, school);
			}
			catch (Exception)
			{
				throw;
			}
		}
	}
}