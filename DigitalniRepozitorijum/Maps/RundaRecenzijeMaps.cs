using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    class RundaRecenzijeMaps : ClassMap<RundaRecenzije>
    {
        public RundaRecenzijeMaps()
        {
            Table("RUNDA_RECENZIJE");
            CompositeId()
                .KeyReference(x => x.ID_P, "ID_P")
                //.KeyReference(x => x.ID_Recenzenta, "ID_RECENZENTA")
                //.KeyReference(x => x.ID_Urednika, "ID_UREDNIKA")
                .KeyProperty(x => x.BrojRunde, "BROJ_RUNDE");
            Map(x => x.DatumOdluke, "DATUM_ODLUKE").Not.Nullable();
            Map(x => x.KonacnaOdluka, "KONACNA_ODLUKA").Not.Nullable();
            References(x => x.ID_Urednika).Column("ID_U").LazyLoad();

            HasMany(x => x.Recenzenti).KeyColumns.Add("ID_P").KeyColumns.Add("BROJ_RUNDE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
