using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using NHibernate.Engine;
using Swashbuckle.AspNetCore.SwaggerGen;
using System.Net.Sockets;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UlogaUrednikController: ControllerBase
    {
 
        #region  Urednik
        [HttpPost]
        [Route("DodajUrednika/{ID_I}/{uredivackaSekcija}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostUlogaUrednika(int ID_I,string uredjivacaSekcija)
        {
            try
            {
                DataProvider.DodajUrednika(ID_I,uredjivacaSekcija);
                return Ok($"Dodata je uloga Urednika, Istrazivacu sa ID: {ID_I}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiUrednika/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteUrednika(int ID_I)
        {
            try
            {
                DataProvider.ObrisiUrednika(ID_I);
                return Ok($"Obrisana je uloga Urednika, Istrazivacu sa ID: {ID_I}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiUrednika/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetUrednika(int ID_I)
        {
            try
            {
                return new JsonResult(DataProvider.VratiUrednika(ID_I));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }  

        [HttpGet]
        [Route("VratiSveIstrazivaceUrednike")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetUrednike()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveIstrazivaceUrednike());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }  
        #endregion
    }
}