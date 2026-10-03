using System.Globalization;
using datalibrary.Entiteti;


namespace datalibrary.DTOs
{
    public class DodavanjeSoftverskiArtifaktDTO: DodavanjeIstrazivackiRezultatiDTO
    {
        public virtual string ProgramskiJezik { get; set; }
        public virtual string RepoLink { get; set; }
        public virtual string NacinLicenciranja { get; set; }
        public virtual string Dokumentacija { get; set; }
        public virtual int ID_Publikacija { get; set; }
    }
}