using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class KnjigaIliPoglavljaView : IstrazivackiRezultatView
    {
        public virtual string Izdavac { get; set; }
        public virtual string MestoIzdavanja { get; set; }
        public virtual IList<UredjujeView> Urednici { get; set; }

        public KnjigaIliPoglavljaView():base()
        {
            Urednici = new List<UredjujeView>();
        }

        public KnjigaIliPoglavljaView(KnjigaIliPoglavlja k) : base(k)
        {
            Izdavac = k.Izdavac;
            MestoIzdavanja = k.MestoIzdavanja;
        }
    }
}
