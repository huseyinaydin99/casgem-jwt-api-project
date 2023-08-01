using Casgem.JWT.API_Project.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Casgem.JWT.API_Project.Controllers
{
	[Route("api/[controller]")]
	[ApiController]
	public class DefaultController : ControllerBase
	{
		
		[HttpGet("[Action]")]
		public IActionResult Login()
		{
			return Created("",new BuildToken().CreateToken());
		}

		[HttpGet("[Action]")]
		[Authorize]
		public IActionResult CustomerList()
		{
			return Ok("Müşteri listesine eriştiniz...");
		}
	}
}