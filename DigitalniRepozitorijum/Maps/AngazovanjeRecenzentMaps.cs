using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    class AngazovanjeRecenzentMaps : ClassMap<AngazovanjeRecenzent>
    {
        public AngazovanjeRecenzentMaps()
        {
            Table("ANGAZOVANJE_RECENZENT");
            CompositeId()
                .KeyReference(x => x.ID_P, "ID_P")
                .KeyReference(x => x.ID_Recenzenta, "ID_RECENZENTA")
                .KeyProperty(x => x.BrojRunde, "BROJ_RUNDE");


            Map(x => x.Preporuka, "PREPORUKA").Not.Nullable();
            HasMany(x => x.Ocene)
                .KeyColumns.Add("ID_P")
                .KeyColumns.Add("ID_RECENZENTA")
                .KeyColumns.Add("BROJ_RUNDE").LazyLoad().Cascade.All().Inverse();
        }
    }
}
