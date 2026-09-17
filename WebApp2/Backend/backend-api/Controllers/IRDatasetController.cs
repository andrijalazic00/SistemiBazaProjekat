using Microsoft.AspNetCore.Mvc;
using datalibrary;
using datalibrary.DTOs;
using Microsoft.AspNetCore.Http.HttpResults;

namespace WebApp2.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IRDatasetController: ControllerBase
    {

        #region  Dataset
        [HttpPost]
        [Route("DodajDataset")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostDataset(DatasetView datasetView)
        {
            try
            {
                DataProvider.DodajDataset(datasetView);
                return Ok($"Dodat je Dataset ID: {datasetView.ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiDataset/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteDataset(int ID_IR)
        {
            try
            {
                DataProvider.ObrisiDataset(ID_IR);
                return Ok($"Obrisan je Dataset ID: {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiDataset/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetDataset(int ID_IR)
        {
            try
            {
                return new JsonResult(DataProvider.VratiDataset(ID_IR));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiSveDataset")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetAllDataset()
        {
            try
            {
                return new JsonResult(DataProvider.VratiSveDataset());
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajDataset")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateDataset(DatasetView datasetView)
        {
            try
            {
                DataProvider.AzurirajDataset(datasetView);
                return Ok($"Dataset ID: {datasetView.ID_IR} je Azuriran");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        #endregion
        
    }
}