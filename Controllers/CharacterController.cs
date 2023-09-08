using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace dotnet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private static Character priest = new Character(); 

        [HttpGet]
        public ActionResult<Character> Get() 
        {
            return Ok(priest);
        }
    }
}