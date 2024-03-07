using Microsoft.AspNetCore.Mvc;
using Rpg___fiap.Models;

namespace Rpg___fiap.Controllers
{
    [ApiController]
    [Route("/api/[controler")]
    public class CharacterController : ControllerBase
    {
        private static Character Knight = new Character();
        [HttpGet]
        public ActionResult<Character> get()
        {
            return BadRequest(Knight);
        }
    }
}
