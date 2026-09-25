using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class PodrzanaPlatformaView
    {
        public virtual IstrazivackiRezultatView ID_IR { get; set; }
        public virtual string Platforma { get; set; }

        public PodrzanaPlatformaView(PodrzanaPlatforma p)
        {
            ID_IR = new IstrazivackiRezultatView( p.ID_IR);
            Platforma = p.Platforma;
        }
    }
}
