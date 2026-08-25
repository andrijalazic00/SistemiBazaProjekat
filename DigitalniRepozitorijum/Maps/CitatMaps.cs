using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    class CitatMaps : ClassMap<Citat>
    {
        public CitatMaps()
        {
            Table("CITAT");
            CompositeId()
                .KeyReference(x => x.ID_P1, "ID_P1")
                .KeyReference(x => x.ID_P2, "ID_P2");
            Map(x => x.CitirajucaPublikacija, "CITIRAJUCA_PUBLIKACIJA").Not.Nullable();
            Map(x => x.CitiranaPublikacija, "CITIRANA_PUBLIKACIJA").Not.Nullable();
            Map(x => x.TipCitata, "TIP_CITATA").Not.Nullable();
            Map(x => x.MestoCitiranja, "MESTO_CITIRANJA").Not.Nullable();
            Map(x => x.KontekstCitiranja, "KONTEKST_CITIRANJA").Not.Nullable();

           
        }
    }
}
