using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class NewToken {
        public NewToken() {
            Scopes = new HashSet<string>();
        }

        public string OrganizationId { get; set; }
        public string ProjectId { get; set; }
        public string DefaultProjectId { get; set; }
        public HashSet<string> Scopes { get; set; }
        public DateTime? ExpiresUtc { get; set; }
        public string Notes { get; set; }
    }
    
    [ApiController]
    [Route("[controller]")]
    public class TokenController : ControllerBase
    {
        public TokenController()
        {
        }

        [HttpPost]
        public async Task<ActionResult<NewToken>> PostAsync(NewToken token)
        {
            return Ok(token);
        }
    }
}