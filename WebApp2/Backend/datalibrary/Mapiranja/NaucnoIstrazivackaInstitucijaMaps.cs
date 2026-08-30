using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using datalibrary.Entiteti;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Security.Cryptography.X509Certificates;
using NHibernate.Mapping;

namespace datalibrary.Mapiranja
{
    class NaucnoIstrazivackaInstitucijaMaps:ClassMap<NaucnoIstrazivackaInstitucija>
    {
        public NaucnoIstrazivackaInstitucijaMaps()
        {
            //Mapiranje tabele
            Table("NI_INSTITUCIJA");
            //Mapiranje PK
            Id(x => x.ID_NII, "ID_NII").GeneratedBy.Sequence("SEQ_NI_INSTITUCIJA");
            //Mapiranje prostih entiteta
            Map(x => x.Naziv, "NAZIV");
            Map(x => x.Adresa, "ADRESA");
            //1:N veza NII:Maliovi/telefoni
            HasMany(x=>x.Mailovi).KeyColumn("ID_NII").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Telefoni).KeyColumn("ID_NII").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.NaucneOblasti).KeyColumn("ID_NII").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Istrazivaci).KeyColumn("ID_NII").LazyLoad().Cascade.All().Inverse();
        }
    }
}
