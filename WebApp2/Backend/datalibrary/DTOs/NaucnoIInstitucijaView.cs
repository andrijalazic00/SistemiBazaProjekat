using datalibrary.Entiteti;
using datalibrary.Mapiranja;
using DigitalniRepozitorijum.Entities;

namespace datalibrary.DTOs
{
    public class NaucnoIInstitucijaView
    {
        public int ID_NII {get; set;}
        public string Naziv {get; set; }
        public string Adresa {get; set; }


    public NaucnoIInstitucijaView( NaucnoIInstitucija i)
        {
            ID_NII = i.ID_NII;
            Naziv = i.Naziv;
            Adresa = i.Adresa;
        }
    }

}