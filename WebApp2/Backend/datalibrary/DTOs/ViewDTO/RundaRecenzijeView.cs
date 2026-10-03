using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class RundaRecenzijeView
    {
        public virtual int BrojRunde { get; set; }
        public virtual PublikacijaView ID_P { get; set; }
        public virtual UrednikView ID_Urednika { get; set; }
        public virtual DateTime DatumOdluke { get; set; }
        public virtual string KonacnaOdluka { get; set; }
        public virtual IList<AngazovanjeRecenzentView>? Recenzenti { get; set; }


        public RundaRecenzijeView()
        {
            Recenzenti = new List<AngazovanjeRecenzentView>();
        }
        public RundaRecenzijeView(RundaRecenzije r)
        {
            BrojRunde = r.BrojRunde;
            ID_P = new PublikacijaView( r.ID_P);
            ID_Urednika = new UrednikView( r.ID_Urednika);
            DatumOdluke = r.DatumOdluke;
            KonacnaOdluka = r.KonacnaOdluka;
        }
    }
}
