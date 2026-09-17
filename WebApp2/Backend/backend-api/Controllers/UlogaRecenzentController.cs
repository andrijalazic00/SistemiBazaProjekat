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
    public class UlogaRecenzentController: ControllerBase
    {

        #region  Recenzent
        [HttpPost]
        [Route("DodajRecenzenta/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PostRecenzenta(int ID_I)
        {
            try
            {
                DataProvider.DodajRecenzenta(ID_I);
                return Ok($"Dodata je uloga Recenzenta, Istrazivacu sa ID: {ID_I}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiRecenzenta/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteRecenzenta(int ID_I)
        {
            try
            {
                DataProvider.ObrisiRecenzenta(ID_I);
                return Ok($"Obrisana je uloga Recenzenta, Istrazivacu sa ID: {ID_I}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiRecenzenta/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRecenzenta(int ID_I)
        {
            try
            {
                return new JsonResult(DataProvider.VratiRecenzenta(ID_I));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        } 

        [HttpPost]
        [Route("DodajOblastEkspertize/{ID_U}/{oblast}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PostOblastEkspertize(int ID_U,string oblast)
        {
            try
            {
                DataProvider.DodajOblastiEkspertize(ID_U,oblast);
                return Ok($"Dodata je Oblast ekspertize Recenzentu sa ID: {ID_U}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiOblastEkspertize/{ID_U}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult DeleteOblastEkspertize(int ID_U, string oblast)
        {
            try
            {
                DataProvider.ObrisiOblastiEkspertize(ID_U,oblast);
                return Ok($"Obrisana je Oblast Ekpserize {oblast}, Recenzentu: {ID_U}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiSveRecenzente")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetRecenzente()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveIstrazivaceRecenzente());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }  
        #endregion
    }
}