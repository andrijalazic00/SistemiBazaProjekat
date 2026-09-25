using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class OcenaRecenzentaView
    {
        public virtual int ID_O { get; protected set; }
        public virtual AngazovanjeRecenzentView AngazovanjeRecenzent { get; set; }
        public virtual int Ocena { get; set; }

        public OcenaRecenzentaView(OcenaRecenzenta o)
        {
            ID_O = o.ID_O;
            AngazovanjeRecenzent = new AngazovanjeRecenzentView( o.AngazovanjeRecenzent);
            Ocena = o.Ocena;
        }
    }
}
