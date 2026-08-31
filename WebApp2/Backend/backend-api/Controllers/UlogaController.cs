using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using NHibernate.Engine;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UlogaController: ControllerBase
    {
        [HttpGet]
        [Route("VratiUloge")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetUloge()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveUloge());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}