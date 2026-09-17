using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IROstaliDokumentiController: ControllerBase
    {
                #region  Ostali Dokument
            [HttpPost]
            [Route("DodajOstaliDokument")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult PostOstaliDokument(OstaliDokumentiView ostaliDokumentiView)
            {
                try
                {
                    DataProvider.DodajOstaliDokument(ostaliDokumentiView);
                    return Ok($"Dodat je {ostaliDokumentiView.Opcije} ID: {ostaliDokumentiView.ID_IR}");
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpDelete]
            [Route("ObrisiOstaliDokument/{ID_IR}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult DeleteOstaliDokument(int ID_IR)
            {
                try
                {
                    DataProvider.ObrisiOstaliDokument(ID_IR);
                    return Ok($"Obrisan je Dokument ID: {ID_IR}");
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpGet]
            [Route("VratiOstaliDokument/{ID_IR}")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult GetOstaliDokument(int ID_IR)
            {
                try
                {
                    return new JsonResult(DataProvider.VratiOstaliDokument(ID_IR));
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }

            [HttpPut]
            [Route("AzurirajOstaliDokument")]
            [ProducesResponseType(StatusCodes.Status200OK)]
            [ProducesResponseType(StatusCodes.Status400BadRequest)]
            public IActionResult UpdateOstaliDokument(OstaliDokumentiView ostaliDokumentiView)
            {
                try
                {
                    DataProvider.AzurirajOstaliDokument(ostaliDokumentiView);
                    return Ok($"Dokument {ostaliDokumentiView.Opcije} ID: {ostaliDokumentiView.ID_IR} je Azuriran");
                }
                catch(Exception ex)
                {
                    return BadRequest(ex.ToString());
                }
            }
            #endregion
    }
}