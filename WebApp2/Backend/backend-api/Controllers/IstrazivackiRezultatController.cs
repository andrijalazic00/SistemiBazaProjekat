using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IstrazivackiRezultatController: ControllerBase
    {
        
        [HttpGet]
        [Route("VratiIstrazivackeRezultate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllIstrazivackeRezultate()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveIstrazivackeRezultate());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}