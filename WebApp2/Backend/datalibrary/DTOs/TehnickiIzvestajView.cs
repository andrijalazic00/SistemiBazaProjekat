using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class TehnickiIzvestajView : IstrazivackiRezultatView
    {
        public virtual PublikacijaView Publikacija { get; set; }

        public TehnickiIzvestajView(TehnickiIzvestaj t) : base(t)
        {
            Publikacija = new PublikacijaView( t.Publikacija);
        }
    }
}
