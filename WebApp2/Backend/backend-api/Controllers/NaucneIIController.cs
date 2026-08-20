using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using databaseacesslib;

namespace WebApp2.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class NaucneIIController: ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiInstitucije")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetInstitucije()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveInstitucije());
            }
            catch( Exception ex)
            {
                return BadRequest( ex.ToString());
            }
        }
    }
}