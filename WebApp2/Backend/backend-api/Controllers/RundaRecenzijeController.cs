using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;
using datalibrary.Entiteti;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RundaRecenzijeController: ControllerBase
    {
        [HttpPost]
        [Route("DodajRunduRecenzije")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddRundaRecenzije(RundaRecenzijeView rundaRecenzijeView)
        {
            try
            {
                DataProvider.DodajRunduRecenzije(rundaRecenzijeView);
                return Ok($"Dodata je Runda Recenzije za publikaciju {rundaRecenzijeView.ID_P.ID_P}, Broj Runde {rundaRecenzijeView.BrojRunde}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajAngazovaneRecenzente")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddAngazovaneRecenzente(AngazovanjeRecenzentView angazovanjeRecenzentView)
        {
            try
            {
                DataProvider.DodajAngazovaneRecenzente(angazovanjeRecenzentView);
                return Ok($"Dodato je Angazovanje Recenzenta {angazovanjeRecenzentView.ID_Recenzenta.ID_U} za Publikaciju {angazovanjeRecenzentView.ID_P.ID_P}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajOcenaAngazovanomRecenzentu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult AddOcenaAngazovanomRecenzentu(int ID_AR, int ocena)
        {
            try
            {
                DataProvider.DodajOceneAngazovanomRecenzentu(ID_AR,ocena);
                return Ok($"Dodato je ocena {ocena} Angazovanom Recenzentu {ID_AR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
    }
}