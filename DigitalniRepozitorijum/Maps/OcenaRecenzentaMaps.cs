using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    class OcenaRecenzentaMaps : ClassMap<OcenaRecenzenta>
    {
        public OcenaRecenzentaMaps()
        {
            Table("OCENA_RECENZENTA");
            Id(x => x.ID_O, "ID_O").GeneratedBy.Sequence("SEQ_OCENA_RECENZENTA");
            Map(x => x.Ocena,"OCENA").Not.Nullable();

            References(x => x.AngazovanjeRecenzent).Columns("ID_P","ID_RECENZENTA","BROJ_RUNDE").Not.Nullable();
            //References(x => x.ID_P).Column("ID_P").LazyLoad().Not.Nullable();
            //References(x => x.ID_Recenzenta).Column("ID_U" ).LazyLoad().Not.Nullable();

        }
    }
}
