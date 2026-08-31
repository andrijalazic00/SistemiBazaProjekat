using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using NHibernate.Engine;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IstrazivacController: ControllerBase
    {
        [HttpGet]
        [Route("PreuzmiSveIstrazivace")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetIstrazivaci()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveIstrazivace());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("PreuzmiIstrazivaca")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetIstrazivaca(int ID_I)
        {
            try
            {
                return new JsonResult(DataProvider.VratiIstrazivaca(ID_I));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        [Route("DodajMailIstrazivacu/{ID_I}/{mail}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddMailToIstrazivac(int ID_I, string mail)
            {
                try
                {
                    DataProvider.DodajMailIstrazivacu(ID_I, mail);
                    return Ok();
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

        [HttpPost]
        [Route("DodajTelefonIstrazivacu/{ID_I}/{phone}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPhoneToIstrazivac(int ID_I, string phone)
            {
                try
                {
                    DataProvider.DodajTelefonIstrazivacu(ID_I, phone);
                    return Ok();
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

        [HttpGet]
        [Route("VratiMailIstrazivaca/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetMailIstrazivac(int ID_I)
            {
                try
                {
                    return new JsonResult(DataProvider.VratiMailoveIstrazivaca(ID_I));
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

        [HttpDelete]
        [Route("ObrisiMailIstrazivaca/{ID_NII},{mail}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteMailIstrazivac(int ID_I, string mail)
        {
            try
            {
                DataProvider.ObrisiMailIstrazivacu(ID_I, mail);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AnzurirajMailIstrazivaca/{ID_I}/{oldmail}/{newmail}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateMailIstrazivac(int ID_I, string oldmail, string newmail)
        {
            try
            {
                DataProvider.AnzurirajMailIstrazivacu(ID_I, oldmail,newmail);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiTelefoneIstrazivac/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPhonesIstrazivac(int ID_I)
            {
                try
                {
                    return new JsonResult(DataProvider.VratiTelefoneIstrazivaca(ID_I));
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

        [HttpDelete]
        [Route("ObrisiTelefonIstrazivac/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePhoneIstrazivac(int ID_I, string broj)
        {
            try
            {
                DataProvider.ObrisiTelefonIstrazivacu(ID_I, broj);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AnzurirajTelefonIstrazivac/{ID_I}/{oldphone}/{newphone}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdatePhoneIstrazivac(int ID_I, string oldphone, string newphone)
        {
            try
            {
                DataProvider.AnzurirajTelefonIstrazivacu(ID_I, oldphone,newphone);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("AngazujIstrazivacaUInstitut")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult SetIstrazivacUInstituciju([FromBody] AngazovanjeView angazovanje)
        {
            try
            {
                DataProvider.AngazujIstrazivacaUInstituciju(angazovanje);
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}