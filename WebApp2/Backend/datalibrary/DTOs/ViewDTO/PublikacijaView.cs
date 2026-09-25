using datalibrary.Entiteti;
using FluentNHibernate.Conventions.AcceptanceCriteria;

namespace datalibrary.DTOs
{
    public class PublikacijaView
    {
        public virtual int ID_P { get; set; }
        public virtual DatasetView? ID_D { get; set; }
        public virtual TehnickiIzvestajView? ID_TI { get; set; }
        public virtual SoftverskiArtifaktView? ID_SA { get; set; }
        public virtual IList<CitatView> CitirajucePublikacije { get; set; } = [];
        public virtual IList<CitatView> CitiranePublikacije { get; set; } = [];
        public virtual IList<RundaRecenzijeView> RundeRecenzije { get; set; } = [];
        public virtual IList<AutorstvoView> Autorstva { get; set; } = [];

        public PublikacijaView(Publikacija p) : this(p, true)
        {
        }

        public PublikacijaView(Publikacija p, bool includeRelatedResults)
        {
            ID_P = p.ID_P;
            if (includeRelatedResults)
            {
                ID_D = p.ID_D == null ? null : new DatasetView(p.ID_D);
                ID_TI = p.ID_TI == null ? null : new TehnickiIzvestajView(p.ID_TI);
                ID_SA = p.ID_SA == null ? null : new SoftverskiArtifaktView(p.ID_SA);
            }
        }

        public PublikacijaView()
        {
            CitirajucePublikacije = [];
            CitiranePublikacije = [];
            RundeRecenzije = [];
            Autorstva = [];
        }

        public static implicit operator PublikacijaView(Publikacija v)
        {
            return new PublikacijaView(v);
        }
    }
}
