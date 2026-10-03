using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    class SoftverskiArtifaktMaps : SubclassMap<SoftverskiArtifakt>
    {
        public SoftverskiArtifaktMaps()
        {
            Table("SOFTVERSKI_ARTIFAKT");
            KeyColumn("ID_IR");
            Map(x => x.ProgramskiJezik, "PROGRAMSKI_JEZIK").Not.Nullable();
            Map(x => x.RepoLink, "REPO_LINK").Not.Nullable();
            Map(x => x.NacinLicenciranja, "NACIN_LICENCIRANJA").Not.Nullable();
            Map(x => x.Dokumentacija, "DOKUMENTACIJA").Not.Nullable();

            HasOne(x => x.Publikacija).PropertyRef(x => x.SoftverskiArtifaktID);

            HasMany(x => x.PodrzanePlatforme).KeyColumn("ID_IR").LazyLoad().Cascade.All().Inverse();
        }
    }
}
