using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IRTehnickiIzvestajController: ControllerBase
    {

 
       #region  Tehnicki Izvestaj

        [HttpPost]
        [Route("DodajTehnickiIzvestaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostTehnickiIzvestaj(DodavanjeIstrazivackiRezultatiDTO tehnickiIzvestajView)
        {
            try
            {
                DataProvider.DodajTehnickiIzvestaj(tehnickiIzvestajView);
                return Ok($"Dodat je Tehnicki Izvestaj ID: {tehnickiIzvestajView.ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiTehnickiIzvestaj/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteTehnickiIzvestaj(int ID_IR)
        {
            try
            {
                DataProvider.ObrisiTehnickiIzvestaj(ID_IR);
                return Ok($"Obrisan je TehnickiIzvestaj ID: {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiTehnickiIzvestaj/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTehnickiIzvestaj(int ID_IR)
        {
            try
            {
                return new JsonResult(DataProvider.VratiTehnickiIzvestaj(ID_IR));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiSveTehnickiIzvestaje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllTehnickiIzvestaj()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveTehnickiIzvestaje());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajTehnickiIzvestaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateTehnickiIzvestaj(TehnickiIzvestajView tehnickiIzvestajView)
        {
            try
            {
                DataProvider.AzurirajTehnickiIzvestaj(tehnickiIzvestajView);
                return Ok($"Tehnicki Izvestaj ID: {tehnickiIzvestajView.ID_IR} je Azuriran");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        
        #endregion
        
    }
}