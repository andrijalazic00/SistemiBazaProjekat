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
    public class UlogaRukovodilacController: ControllerBase
    {
        #region  Rukovodilac
        [HttpPost]
        [Route("DodajUloguRukovodilacProjekta/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostUlogaRukovodilacProjekta(int ID_I)
        {
            try
            {
                DataProvider.DodajRukovodioca(ID_I);
                return Ok($"Dodata je uloga Rukovodilac Projekta, Istrazivacu sa ID: {ID_I}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiUloguRukovodilacProjekta/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteRukovodilacProjekta(int ID_I)
        {
            try
            {
                DataProvider.ObrisiRukovodioca(ID_I);
                return Ok($"Obrisana je uloga Rukovodilac Projekta, Istrazivacu sa ID: {ID_I}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiUloguRukovodilacProjekta/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRukovodilacProjekta(int ID_I)
        {
            try
            {
                return new JsonResult(DataProvider.VratiRukovodioca(ID_I));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }   


        [HttpGet]
        [Route("VratiSveIstrazivaceRukovodioce")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllRukovodioci()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveIstrazivaceRukovodioce());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }   

        #endregion
    }
}