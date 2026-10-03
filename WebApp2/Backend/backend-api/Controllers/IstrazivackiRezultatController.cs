using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IstrazivackiRezultatController: ControllerBase
    {
        
        [HttpGet]
        [Route("VratiIstrazivackeRezultate")]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllIstrazivackeRezultate()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveIstrazivackeRezultate());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajKljucneReci/{ID_IR}/{kljucnaRec}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddKeyWords(int ID_IR, string kljucnaRec)
        {
            try
            {
                DataProvider.DodajKljucneReci(ID_IR,kljucnaRec);
                return Ok($"Kljucna Rec {kljucnaRec} je dodata u Istrazivacki Rad {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiKljucnuRec/{ID_IR}/{kljucnaRec}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteKeyWords(int ID_IR, string kljucnaRec)
        {
            try
            {
                DataProvider.ObrisiKljucnuRec(ID_IR,kljucnaRec);
                return Ok($"Kljucna Rec {kljucnaRec} je izbrisana iz Istrazivackog Rada {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajVerzijuIR")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddVersionToIR(VerzijaView verzijaView)
        {
            try
            {
                DataProvider.DodajVerzijuIR(verzijaView);
                return Ok($"Verzija Br: {verzijaView.BrojVerzije} Dodata Istrazivackom Radu {verzijaView.ID_IR.ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPripadajuciFajl")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPripadajuciFajl(PripadajuciFajlView pripadajuciFajlView)
        {
            try
            {
                DataProvider.DodajPripadajuciFajl(pripadajuciFajlView);
                return Ok($"Fajl {pripadajuciFajlView.NazivFajla} je dodata u Verziju {pripadajuciFajlView.BrojVerzije} Istrazivackog rada {pripadajuciFajlView.ID_IR.ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        } 

 
    }
}