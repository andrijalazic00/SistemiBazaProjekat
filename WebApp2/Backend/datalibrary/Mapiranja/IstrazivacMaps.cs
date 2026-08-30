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
    public class IstrazivacMaps:ClassMap<Istrazivac>
    {
        public IstrazivacMaps()
        {
            Table("ISTRAZIVAC");

            Id(x => x.ID_I, "ID_I").GeneratedBy.Sequence("SEQ_ISTRAZIVAC");
            //Mapiranje prostih entiteta
            Map(x => x.Ime, "IME");
            Map(x => x.DatumRodjenja, "DATUM_RODJENJA");
            Map(x => x.Drzava, "DRZAVA");
            Map(x => x.Prezime, "PREZIME");
            Map(x => x.NaucnaOblast, "NAUCNA_OBLAST");
            Map(x => x.NaucnoZvanje, "NAUCNO_ZVANJE");
            Map(x => x.StatusNaucnika, "STATUS_NAUCNIKA");

            HasMany(x => x.Mailovi).KeyColumn("ID_I").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Telefoni).KeyColumn("ID_I").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Uloge).KeyColumn("ID_I").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Institucije).KeyColumn("ID_I").LazyLoad().Cascade.All().Inverse();
        }

    }
}
