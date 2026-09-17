using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IRNaucniRadoviController: ControllerBase
    {

        #region  Naucni Rad

        [HttpPost]
        [Route("DodajNaucniRad")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostNaucniRad(NaucniRadView naucniRadView)
        {
            try
            {
                DataProvider.DodajNaucniRad(naucniRadView);
                return Ok($"Dodat je Naucni Rad ID: {naucniRadView.ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiNaucniRad/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteNaucniRad(int ID_IR)
        {
            try
            {
                DataProvider.ObrisiNaucniRad(ID_IR);
                return Ok($"Obrisan je Naucni Rad ID: {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiNaucniRad/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetNaucniRad(int ID_IR)
        {
            try
            {
                return new JsonResult(DataProvider.VratiNaucniRad(ID_IR));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajNaucniRad")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateNaucniRad(NaucniRadView naucniRadView)
        {
            try
            {
                DataProvider.AzurirajNaucniRad(naucniRadView);
                return Ok($"Naucni Rad ID: {naucniRadView.ID_IR} je Azurirana");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        #endregion
     
    }
}