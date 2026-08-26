using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using databaseacesslib;
using NHibernate.Engine;

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
                return new JsonResult(DataProvider.VratiInstitucije());
            }
            catch( Exception ex)
            {
                return BadRequest( ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajNaucnoIstrazivackuInstituciju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddNaucnoIstrazivackaInstitucija([FromBody]NaucnoIstrazivackaInstitucijaView n)
        {
            try
            {
                DataProvider.DodajNaucnoIstrazivackuIstituciju(n);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("PromeniNaucnoIstrazivackuInstituciju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult ChangeNaucnoIstrazivackuInstituciju([FromBody] NaucnoIstrazivackaInstitucijaView n)
        {
            try
            {
                DataProvider.AnzurirajNaucnoIstrazivackuInstituciju(n);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        
        [HttpDelete]
        [Route("ObrisiNaucnoIstrazivackuInstituciju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteNaucnoIstrazivackuInstituciju( int id)
        {
            try
            {
                DataProvider.ObrisiNaucnoIstrazivackuInstituciju(id);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}