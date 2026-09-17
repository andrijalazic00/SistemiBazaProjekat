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
    public class UlogaAdministratorController: ControllerBase
    {
        #region  Administrator
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

        [HttpGet]
        [Route("VratiSveIstrazivaceAdministratore")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAdministatoreRepozitorijuma()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveIstrazivaceAdministratore());
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
        #endregion
    }
}