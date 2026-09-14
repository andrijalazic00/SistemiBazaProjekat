using datalibrary.Entiteti;
using FluentNHibernate.Conventions.AcceptanceCriteria;

namespace datalibrary.DTOs
{
    public class PublikacijaView
    {
        public virtual int ID_P { get; protected set; }
        public virtual DatasetView ID_D { get; set; }
        public virtual TehnickiIzvestajView ID_TI { get; set; }
        public virtual SoftverskiArtifaktView ID_SA { get; set; }
        public virtual IList<CitatView> CitirajucePublikacije { get; set; }
        public virtual IList<CitatView> CitiranePublikacije { get; set; }
        public virtual IList<RundaRecenzijeView> RundeRecenzije { get; set; }
        public virtual IList<AutorstvoView> Autorstva { get; set; }

        public PublikacijaView(Publikacija p)
        {
            ID_P = p.ID_P;
            ID_D = new DatasetView( p.ID_D);
            ID_TI = new TehnickiIzvestajView( p.ID_TI);
            ID_SA = new SoftverskiArtifaktView( p.ID_SA);
        }

        public PublikacijaView()
        {
            CitirajucePublikacije = new List<CitatView>();
            CitiranePublikacije = new List<CitatView>();
            RundeRecenzije = new List<RundaRecenzijeView>();
            Autorstva = new List<AutorstvoView>();
        }

        public static implicit operator PublikacijaView(Publikacija v)
        {
            throw new NotImplementedException();
        }
    }
}
