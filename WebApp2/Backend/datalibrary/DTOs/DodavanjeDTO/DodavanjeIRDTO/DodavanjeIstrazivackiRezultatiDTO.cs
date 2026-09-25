using datalibrary.Entiteti;


namespace datalibrary.DTOs
{
    public class DodavanjeIstrazivackiRezultatiDTO
    {

        public virtual int ID_IR { get; protected set; }
        public virtual string Naslov { get; set; }
        public virtual string Apstrakt { get; set; }
        public virtual DateTime DatumKreiranja { get; set; }
        public virtual DateTime DatumObjavljivanja { get; set; }
        public virtual string StatusIR { get; set; }
        public virtual int Vidljivost { get; set; }

    }
}