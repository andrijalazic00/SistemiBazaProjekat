using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IRSoftverskiArtifaktController: ControllerBase
    {

        #region  Softverski Artifakt
        [HttpPost]
        [Route("DodajSoftverskiArtifakt")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostSoftverskiArtifakt(SoftverskiArtifaktView softverskiArtifaktView)
        {
            try
            {
                DataProvider.DodajSoftverskiArtifakt(softverskiArtifaktView);
                return Ok($"Dodat je Softver ID: {softverskiArtifaktView.ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiSoftverskiArtifakt/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteSoftverskiArtifakt(int ID_IR)
        {
            try
            {
                DataProvider.ObrisiSoftverskiArtifakt(ID_IR);
                return Ok($"Obrisan je Softver ID: {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiSoftverskiArtifakt/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetSoftverskiArtifakt(int ID_IR)
        {
            try
            {
                return new JsonResult(DataProvider.VratiSoftverskiArtifakt(ID_IR));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiSveSoftverskeArtifakte")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllSoftverskiArtifakt()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveSoftverskeArtifakte());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajSoftverskiArtifakt")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateSoftverskiArtifakt(SoftverskiArtifaktView softverskiArtifaktView)
        {
            try
            {
                DataProvider.AzurirajSoftverskiArtifakt(softverskiArtifaktView);
                return Ok($"Softver ID: {softverskiArtifaktView.ID_IR} je Azuriran");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost]
        [Route("DodajPodrzanuPlatformu/{ID_IR}/{platforma}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostPodrzanaPlaforma(int ID_IR, string platfoma)
        {
            try
            {
                DataProvider.DodajPodrzanuPlatformu(ID_IR, platfoma);
                return Ok($"Dodat je Podrzana plaforma {platfoma} za Softver ID: {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiPodrzanuPlatformu/{ID_IR}/{platforma}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeletePodrzanaPlaforma(int ID_IR, string platfoma)
        {
            try
            {
                DataProvider.ObrisiPodrzanuPlatformu(ID_IR,platfoma);
                return Ok($"Obrisan je Podrzana plaforma {platfoma} za Softver ID: {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
        
    }
}