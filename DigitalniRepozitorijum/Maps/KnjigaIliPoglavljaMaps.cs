using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    class KnjigaIliPoglavljaMaps : SubclassMap<KnjigaIliPoglavlja>
    {
        public KnjigaIliPoglavljaMaps()
        {
            Table("KNJIGA_ILI_POGLAVLJA");
            KeyColumn("ID_IR");
            Map(x => x.Izdavac, "IZDAVAC").Not.Nullable();
            Map(x => x.MestoIzdavanja, "MESTO_IZDAVANJA").Not.Nullable();
            HasMany(x => x.Urednici).KeyColumn("ID_IR").LazyLoad().Cascade.All().Inverse();
        }
    }
}
