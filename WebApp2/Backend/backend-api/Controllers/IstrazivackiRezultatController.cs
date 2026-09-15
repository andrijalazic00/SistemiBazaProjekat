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

        #region  Tehnicki Izvestaj

        [HttpPost]
        [Route("DodajTehnickiIzvestaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostTehnickiIzvestaj(TehnickiIzvestajView tehnickiIzvestajView)
        {
            try
            {
                DataProvider.DodajTehnickiIzvestaj(tehnickiIzvestajView);
                return Ok($"Dodat je Tehnicki Izvestaj ID: {tehnickiIzvestajView.ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiTehnickiIzvestaj/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteTehnickiIzvestaj(int ID_IR)
        {
            try
            {
                DataProvider.ObrisiTehnickiIzvestaj(ID_IR);
                return Ok($"Obrisan je TehnickiIzvestaj ID: {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiTehnickiIzvestaj/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetTehnickiIzvestaj(int ID_IR)
        {
            try
            {
                return new JsonResult(DataProvider.VratiTehnickiIzvestaj(ID_IR));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajTehnickiIzvestaj")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateTehnickiIzvestaj(TehnickiIzvestajView tehnickiIzvestajView)
        {
            try
            {
                DataProvider.AzurirajTehnickiIzvestaj(tehnickiIzvestajView);
                return Ok($"Tehnicki Izvestaj ID: {tehnickiIzvestajView.ID_IR} je Azuriran");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }
        
        #endregion

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
                return Ok($"Dodata je Knjiga ili Poglavlje {knjigaIliPoglavljaView.Naslov} ID: {knjigaIliPoglavljaView.ID_IR}");
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

        #region  Naucni Rad

        [HttpPost]
        [Route("DodajNaucniRad")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult PostNaucniRad(NaucniRadView naucniRadView)
        {
            try
            {
                DataProvider.DodajNaucniRad(naucniRadView);
                return Ok($"Dodat je Naucni Rad ID: {naucniRadView.ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpDelete]
        [Route("ObrisiNaucniRad/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult DeleteNaucniRad(int ID_IR)
        {
            try
            {
                DataProvider.ObrisiNaucniRad(ID_IR);
                return Ok($"Obrisan je Naucni Rad ID: {ID_IR}");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        [Route("VratiNaucniRad/{ID_IR}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult GetNaucniRad(int ID_IR)
        {
            try
            {
                return new JsonResult(DataProvider.VratiNaucniRad(ID_IR));
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPut]
        [Route("AzurirajNaucniRad")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public IActionResult UpdateNaucniRad(NaucniRadView naucniRadView)
        {
            try
            {
                DataProvider.AzurirajNaucniRad(naucniRadView);
                return Ok($"Naucni Rad ID: {naucniRadView.ID_IR} je Azurirana");
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        #endregion
    }
}