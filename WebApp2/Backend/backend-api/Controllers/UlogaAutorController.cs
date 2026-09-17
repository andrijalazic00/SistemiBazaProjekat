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
    public class UlogaAutorController: ControllerBase
    {
        
        #region  Autor
        [HttpPost]
        [Route("DodajAutora/{ID_I}/{ORDCID}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PostAutora(int ID_I,string ORDCID)
        {
            try
            {
                DataProvider.DodajAutora(ID_I, ORDCID);
                return Ok($"Dodata je uloga Autora, Istrazivacu sa ID: {ID_I}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiAutora/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteAutora(int ID_I)
        {
            try
            {
                DataProvider.ObrisiAutora(ID_I);
                return Ok($"Obrisana je uloga Autora, Istrazivacu sa ID: {ID_I}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiAutora/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAutora(int ID_I)
        {
            try
            {
                return new JsonResult(DataProvider.VratiAutora(ID_I));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        } 

        [HttpGet]
        [Route("VratiSveAutore")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAutors()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveIstrazivaceAutore());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }  
        #endregion
    }
}