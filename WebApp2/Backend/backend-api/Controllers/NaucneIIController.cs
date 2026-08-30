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

        [HttpPost]
        [Route("DodajTelefonInstituciji")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPhoneToInstitution(int ID_NII, string mail)
            {
                try
                {
                    DataProvider.DodajTelefonInstituciji(ID_NII, mail);
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

        [HttpDelete]
        [Route("ObrisiMailInstitucije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteMailInstitution(int ID_NII, string mail)
        {
            try
            {
                DataProvider.ObrisiMailIstituciji(ID_NII, mail);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AnzurirajMailInstitucije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateMailInstitution(int ID_NII, string oldmail, string newmail)
        {
            try
            {
                DataProvider.AnzurirajMailInstituciji(ID_NII, oldmail,newmail);
                return Ok();
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

        [HttpDelete]
        [Route("ObrisiTelefonInstitucije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePhoneInstitution(int ID_NII, string broj)
        {
            try
            {
                DataProvider.ObrisiTelefonIstituciji(ID_NII, broj);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AnzurirajTelefonInstitucije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePhoneInstitution(int ID_NII, string oldphone, string newphone)
        {
            try
            {
                DataProvider.AnzurirajTelefonInstituciji(ID_NII, oldphone,newphone);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }

}