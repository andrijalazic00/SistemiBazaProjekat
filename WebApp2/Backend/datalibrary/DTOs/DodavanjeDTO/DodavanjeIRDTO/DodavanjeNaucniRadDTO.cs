using datalibrary.Entiteti;


namespace datalibrary.DTOs
{
    public class DodavanjeNaucniRadDTO: DodavanjeIstrazivackiRezultatiDTO
    {

        public virtual string TipRada { get; set; }
        public virtual string NazivCasKon { get; set; }
        public virtual string Doi { get; set; }
        public virtual string IssnIliIsbn { get; set; }
        public virtual int BrojSveske { get; set; }
        public virtual int BrojIzdanja { get; set; }
        public virtual int BrojStranice { get; set; }
        
    }
}