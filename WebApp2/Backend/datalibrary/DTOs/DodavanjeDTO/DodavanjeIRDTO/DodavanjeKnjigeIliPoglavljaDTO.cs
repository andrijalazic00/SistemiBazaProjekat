using datalibrary.Entiteti;


namespace datalibrary.DTOs
{
    public class DodavanjeKnjigeIliPoglavnjaDTO: DodavanjeIstrazivackiRezultatiDTO
    {

        public virtual string Izdavac { get; set; }
        public virtual string MestoIzdavanja { get; set; }

    }
}