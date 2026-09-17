using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IRKnjigeIliPoglavljaController: ControllerBase
    {

        #region  Knjiga/Poglavlje

        [HttpPost]
        [Route("DodajKnjigeIliPoglavlje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostKnjigeIliPoglavlje(KnjigaIliPoglavljaView knjigaIliPoglavljaView)
        {
            try
            {
                DataProvider.DodajKnjigeIliPoglavlja(knjigaIliPoglavljaView);
                return Ok($"Dodata je Knjiga ili Poglavlje {knjigaIliPoglavljaView.Naslov}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpPost]
        [Route("DodajUrednikaKnjizi/{ID_U}/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostUrednikKnjizi(int ID_U, int ID_IR)
        {
            try
            {
                DataProvider.DodajUrednikaKnjizi(ID_U,ID_IR);
                return Ok($"Dodat je urednik {ID_U} knjizi {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }        

        [HttpDelete]
        [Route("ObrisiKnjigeIliPoglavlje/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteKnjigeIliPoglavlje(int ID_IR)
        {
            try
            {
                DataProvider.ObrisiKnjigeIliPoglavlja(ID_IR);
                return Ok($"Obrisana je Knjiga ili Poglavlje ID: {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiKnjigeIliPoglavlje/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetKnjigeIliPoglavlje(int ID_IR)
        {
            try
            {
                return new JsonResult(DataProvider.VratiKnjigeIliPoglavlja(ID_IR));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }


        [HttpGet]
        [Route("VratiSveKnjigeIliPoglavlje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSveKnjigeIliPoglavlje()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveKnjigeIliPoglavlja());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajKnjigeIliPoglavlje")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateKnjigeIliPoglavlje(KnjigaIliPoglavljaView knjigaIliPoglavljaView)
        {
            try
            {
                DataProvider.AzurirajKnjigeIliPoglavlje(knjigaIliPoglavljaView);
                return Ok($"Knjiga ili Poglavlje {knjigaIliPoglavljaView.Naslov} ID: {knjigaIliPoglavljaView.ID_IR} je Azurirana");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        #endregion
     
    }
}