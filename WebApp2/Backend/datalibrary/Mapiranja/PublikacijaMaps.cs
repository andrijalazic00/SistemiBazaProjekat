using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    class PublikacijaMaps : ClassMap<Publikacija>
    {
        public PublikacijaMaps()
        {
            Table("PUBLIKACIJA");
            Id(x => x.ID_P, "ID_P").GeneratedBy.Sequence("SEQ_PUBLIKACIJA");
            References( x => x.ID_D, "ID_ID").Nullable().Unique();
            References( x => x.ID_TI, "ID_TI").Nullable().Unique();
            References( x => x.ID_SA, "ID_SA").Nullable().Unique();   

            HasMany(x => x.CitiranePublikacije).KeyColumn("ID_P").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.CitirajucePublikacije).KeyColumn("ID_P").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.RundeRecenzije).KeyColumn("ID_P").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Autorstva).KeyColumn("ID_P").LazyLoad().Cascade.All().Inverse();
           
        }
    }
}
