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
        public IActionResult AddPublikacija(AutorstvoView autorstvoView)
        {
            try
            {
                DataProvider.DodajPublikaciju(autorstvoView);
                return Ok($"Dodata je Publikacija sa Autorstvom {autorstvoView.RedniBrojAutora}");
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
        public IActionResult AddCitat(CitatView citatView)
        {
            try
            {
                DataProvider.DodajCitat(citatView);
                return Ok($"Dodata je Citat citirajuci publikaciju {citatView.ID_P1} i citirana publikacija {citatView.ID_P2} ");
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
        
    }
}