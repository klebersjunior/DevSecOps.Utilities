using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DevSecOps.Utilities.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PipelineValidatorController : ControllerBase
    {
 
        [HttpPost("AzDevOps")]
        public void Post([FromBody] string value)
        {
        }


        [HttpPost("CompareBranchs/{branchName}")]
        public void CompareBranchs(string branchName)
        {
        }


    }
}
