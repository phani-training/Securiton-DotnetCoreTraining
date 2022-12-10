using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace SampleJWTExample.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class MembersController : ControllerBase
    {
        private readonly IJwtAuth _auth;
        public MembersController(IJwtAuth auth)
        {
            _auth= auth;
        }

        [AllowAnonymous]
        [HttpPost("Authenticate")]
        public IActionResult Authenticate([FromBody]UserDetail detail)
        {
            var token = _auth.Authenticate(detail.UserName, detail.Password);
            if(token == "User is not validated")
            {
                return Unauthorized();
            }
            return Ok(token);
        }

        [HttpGet("AllMembers")]
        public IActionResult GetMembers() 
        {
            return Ok(new List<Member>
            { 
                new Member{ MemberJob ="Trainer", MemberName ="Phaniraj"},
                new Member{ MemberJob ="Developer", MemberName ="Ramesh"},
                new Member{ MemberJob ="Tester", MemberName ="Sam"},
                new Member{ MemberJob ="Developer", MemberName ="Tony"}
            }); 
        }
    }
}
