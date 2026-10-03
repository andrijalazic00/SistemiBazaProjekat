using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using datalibrary.Entiteti;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PublikacijaController: ControllerBase
    {
        [HttpPost]
        [Route("DodajPublikaciju")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddPublikacija(int ID_U, int redni_broj, string doprinos, string uloga)
        {
            try
            {
                DataProvider.DodajPublikaciju(ID_U, redni_broj, doprinos, uloga);
                return Ok($"Dodata je Publikacija sa Autorstvom {redni_broj}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        [Route("DodajCitat")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddCitat(int ID_P1, int ID_P2, string tip, string mesto, string kontekst)
        {
            var normalizedTip = tip?.Trim().ToUpperInvariant();
            if (normalizedTip is not ("DIREKTAN" or "INDIREKTAN"))
            {
                return BadRequest("Tip citata mora biti DIREKTAN ili INDIREKTAN.");
            }

            try
            {
                DataProvider.DodajCitat(ID_P1,ID_P2,normalizedTip,mesto,kontekst);
                return Ok($"Dodata je Citat citirajuci publikaciju {ID_P1} i citirana publikacija {ID_P2} ");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("VratiPublikaciju/{ID_P}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetPublikacija(int ID_P)
        {
            try
            {
              return new JsonResult(DataProvider.VratiPublikaciju(ID_P));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiSvePublikacije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllPublikacija()
        {
            try
            {
              return new JsonResult(DataProvider.VratiSvePublikacije());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajAutorstvoPublikaciji")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddAutorstvo(DodavanjeAutorstvaDTO dodavanjeAutorstvaDTO)
        {
            try
            {
                DataProvider.DodajAutorstvo(dodavanjeAutorstvaDTO);
                return Ok($"Dodata je Publikacija sa Autorstvom {dodavanjeAutorstvaDTO.ID_U}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajTehnickiIzvestajPublikacijia")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddTehnickiIzvestajPublikacija(int ID_TI, int ID_P)
        {
            try
            {
                DataProvider.DodajTehnickiIzvestajPublikaciji(ID_TI,ID_P);
                return Ok($"Dodat je Tehnicki Izvestaj {ID_TI} publikaciji {ID_P}");
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajDatasetPublikaciji")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddDatasetPublikacija(int ID_D, int ID_P)
        {
            try
            {
                DataProvider.DodajDatasetPublikaciji(ID_D,ID_P);
                return Ok($"Dodat je Dataset {ID_D} publikaciji {ID_P}");
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajSoftverskiArtifakt")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddSoftverskiArtifaktPublikacija(int ID_SA, int ID_P)
        {
            try
            {
                DataProvider.DodajSoftverskiArtifaktPublikaciji(ID_SA,ID_P);
                return Ok($"Dodat je Softverski Artifakt {ID_SA} publikaciji {ID_P}");
            }
            catch(InvalidOperationException ex)
            {
                return BadRequest(ex.Message);
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}