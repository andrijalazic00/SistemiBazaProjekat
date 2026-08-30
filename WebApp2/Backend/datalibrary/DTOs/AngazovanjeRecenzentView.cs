using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class AngazovanjeRecenzentView
    {
        public virtual PublikacijaView ID_P { get; set; }
        public virtual RecenzentView ID_Recenzenta { get; set; }
        public virtual int BrojRunde { get; set; }
        public virtual string Preporuka { get; set; }
        public virtual IList<OcenaRecenzentaView> Ocene { get; set; }

        public AngazovanjeRecenzentView()
        {
            Ocene = new List<OcenaRecenzentaView>();
        }

        public AngazovanjeRecenzentView(AngazovanjeRecenzent a)
        {
            ID_P = new PublikacijaView(a.ID_P);
            ID_Recenzenta = new RecenzentView( a.ID_Recenzenta);
            BrojRunde = a.BrojRunde;
            Preporuka = a.Preporuka;
        }
    }
}
