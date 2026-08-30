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

        [HttpPost]
        [Route("DodajMailInstituciji")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddMailToInstitution(int ID_NII, string mail)
            {
                try
                {
                    DataProvider.DodajMailInstituciji(ID_NII, mail);
                    return Ok();
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

        [HttpGet]
        [Route("VratiMailInstitucije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMailInstitution(int ID_NII)
            {
                try
                {
                    return new JsonResult(DataProvider.VratiMailInstitucije(ID_NII));
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

        [HttpGet]
        [Route("VratiTelefoneInstitucije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPhonesInstitution(int ID_NII)
            {
                try
                {
                    return new JsonResult(DataProvider.VratiBrojeviInstitucije(ID_NII));
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
    }

}