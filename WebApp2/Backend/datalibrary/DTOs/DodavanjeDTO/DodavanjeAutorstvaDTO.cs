using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class DodavanjeAutorstvaDTO
    {
        public virtual int ID_U { get; set; }
        public virtual int ID_P { get; set; }
        public virtual int RedniBrojAutora { get; set; }
        public virtual string TipDoprinosa { get; set; }
        public virtual string UlogaUPublikaciji { get; set; }

        public DodavanjeAutorstvaDTO()
        {
            
        }
    }
}