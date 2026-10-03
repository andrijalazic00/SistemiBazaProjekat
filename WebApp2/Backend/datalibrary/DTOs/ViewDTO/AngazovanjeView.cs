using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class AngazovanjeView
    {
        public virtual AngazovanIstrazivacView ID_I { get; set; }
        public virtual AngazovanNIIInstitucijiView ID_NII { get; set; }
        public virtual DateTime DatumAngazovanja { get; set; }
        public virtual DateTime? DatumZavrsetka { get; set; }
        public virtual string OrganizacionaJedinica { get; set; }
        public virtual string NazivPozicije { get; set; }
        public virtual string TipAngazovanja { get; set; }

        public AngazovanjeView()
        {
        }

        public AngazovanjeView(Angazovanje a)
        {
            ID_I = new AngazovanIstrazivacView( a.ID_I);
            ID_NII = new AngazovanNIIInstitucijiView( a.ID_NII);
            DatumAngazovanja = a.DatumAngazovanja;
            DatumZavrsetka = a.DatumZavrsetka;
            OrganizacionaJedinica = a.OrganizacionaJedinica;
            NazivPozicije = a.NazivPozicije;
            TipAngazovanja = a.TipAngazovanja;
        }
    }
}
