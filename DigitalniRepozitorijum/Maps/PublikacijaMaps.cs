using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    class PublikacijaMaps : ClassMap<Publikacija>
    {
        public PublikacijaMaps()
        {
            Table("PUBLIKACIJA");
            Id(x => x.ID_P, "ID_P").GeneratedBy.Sequence("SEQ_PUBLIKACIJA");
            References(x => x.ID_IR, "ID_IR").Nullable().Unique();

            HasMany(x => x.CitiranePublikacije).KeyColumn("ID_P").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.CitirajucePublikacije).KeyColumn("ID_P").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.RundeRecenzije).KeyColumn("ID_P").LazyLoad().Cascade.All().Inverse();
            HasMany(x => x.Autorstva).KeyColumn("ID_P").LazyLoad().Cascade.All().Inverse();
           
        }
    }
}
