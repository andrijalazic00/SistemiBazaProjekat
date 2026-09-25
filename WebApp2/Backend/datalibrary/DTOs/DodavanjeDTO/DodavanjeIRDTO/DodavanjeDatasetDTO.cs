using datalibrary.Entiteti;


namespace datalibrary.DTOs
{
    public class DodavanjeDatasetDTO: DodavanjeIstrazivackiRezultatiDTO
    {

        public virtual string Format { get; set; }
        public virtual int Velicina { get; set; }
        public virtual int BrojZapisa { get; set; }
        public virtual string OpisStrukture { get; set; }
        public virtual string PeriodObuhvataPodataka { get; set; }
        public virtual string LicencaKoriscenja { get; set; }
        public virtual string OgranicenjaPristupa { get; set; }
        public virtual int ID_Publikacija { get; set; }

    }
}