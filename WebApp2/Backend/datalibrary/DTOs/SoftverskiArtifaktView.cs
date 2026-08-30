using datalibrary.Entiteti;

namespace datalibrary.DTOs
{
    public class SoftverskiArtifaktView : IstrazivackiRezultatView
    {
        public virtual string ProgramskiJezik { get; set; }
        public virtual string RepoLink { get; set; }
        public virtual string NacinLicenciranja { get; set; }
        public virtual string Dokumentacija { get; set; }
        public virtual PublikacijaView Publikacija { get; set; }
        public virtual IList<PodrzanaPlatformaView> PodrzanePlatforme { get; set; }

        public SoftverskiArtifaktView(SoftverskiArtifakt s) : base(s)
        {
            ProgramskiJezik = s.ProgramskiJezik;
            RepoLink = s.RepoLink;
            NacinLicenciranja = s.NacinLicenciranja;
            Dokumentacija = s.Dokumentacija;
            Publikacija = new PublikacijaView(s.Publikacija);
        }

        public SoftverskiArtifaktView():base()
        {
            PodrzanePlatforme = new List<PodrzanaPlatformaView>();
        }
    }
}
