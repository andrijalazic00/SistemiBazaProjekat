using System.Security.Cryptography;
using datalibrary.Entiteti;
using datalibrary.Mapiranja;

namespace datalibrary.DTOs
{
    public class IstrazivacView
    {
        public virtual string Ime { get; set; }
        public virtual DateTime DatumRodjenja { get; set; }
        public virtual string Drzava { get; set; }
        public virtual string Prezime { get; set; }
        public virtual string NaucnaOblast { get; set; }
        public virtual string NaucnoZvanje { get; set; }
        public virtual string StatusNaucnika { get; set; }       

        public IstrazivacView(Istrazivac i)
        {
            Ime = i.Ime;
            DatumRodjenja = i.DatumRodjenja;
            Drzava = i.Drzava;
            Prezime = i.Prezime;
            NaucnaOblast = i.NaucnaOblast;
            NaucnoZvanje = i.NaucnoZvanje;
            StatusNaucnika = i.StatusNaucnika;

        }
    }
}
