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
    public class UlogaController: ControllerBase
    {
        [HttpGet]
        [Route("VratiUloge")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetUloge(int ID_I)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveUlogeIstrazivaca(ID_I));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

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


        [HttpPost]
        [Route("DodajUloguAdministratorRepozitorijuma/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PostUlogaAdministratorRepozitorijuma(int ID_I)
        {
            try
            {
                DataProvider.DodajAdministratoraRepozitorijuma(ID_I);
                return Ok($"Dodata je uloga administrator Repozitorijuma, Istrazivacu sa ID: {ID_I}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiAdministatoraRepozitorijuma/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteAdministatoraRepozitorijuma(int ID_I)
        {
            try
            {
                DataProvider.ObrisiAdministratoraRepozitorijuma(ID_I);
                return Ok($"Obrisana je uloga Administator Repozitorijuma, Istrazivacu sa ID: {ID_I}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiAdministatoraRepozitorijuma/{ID_I}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAdministatoraRepozitorijuma(int ID_I)
        {
            try
            {
                return new JsonResult(DataProvider.VratiAdministratoraRepozitorijuma(ID_I));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }  

        [HttpPost]
        [Route("DodajAdministratorskaOvlascenja/{ID_U}/{ovlascenje}")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public IActionResult PostAdministratorskaOvlascenja(int ID_U, string ovlascenje)
        {
            try
            {
                DataProvider.DodajAdministratorskaOvlascenja(ID_U, ovlascenje);
                return Ok($"Dodato je Ovlascenje Administratoru sa ID: {ID_U}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiAdministratorskaOvlascenja")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteAdministratorskaOvlascenja(AdministratorOvlascenjaView administratorOvlascenjaView)
        {
            try
            {
                DataProvider.ObrisiAdministratoruOvlascenje(administratorOvlascenjaView);
                return Ok($"Obrisano je Ovlascenje Administratoru {administratorOvlascenjaView.ID_U.ID_U}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }   

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
    }
}