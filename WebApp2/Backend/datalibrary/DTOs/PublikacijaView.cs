using datalibrary.Entiteti;
using FluentNHibernate.Conventions.AcceptanceCriteria;

namespace datalibrary.DTOs
{
    public class PublikacijaView
    {
        public virtual int ID_P { get; protected set; }
        public virtual IstrazivackiRezultatView ID_IR { get; set; }
        public virtual IList<CitatView> CitirajucePublikacije { get; set; }
        public virtual IList<CitatView> CitiranePublikacije { get; set; }
        public virtual IList<RundaRecenzijeView> RundeRecenzije { get; set; }
        public virtual IList<AutorstvoView> Autorstva { get; set; }

        public PublikacijaView(Publikacija p)
        {
            ID_P = p.ID_P;
            ID_IR = new IstrazivackiRezultatView( p.ID_IR);
        }

        public PublikacijaView()
        {
            CitirajucePublikacije = new List<CitatView>();
            CitiranePublikacije = new List<CitatView>();
            RundeRecenzije = new List<RundaRecenzijeView>();
            Autorstva = new List<AutorstvoView>();
        }
    }
}
