using DigitalniRepozitorijum.Entities;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DigitalniRepozitorijum.Maps
{
    public class AngazovanjeMaps:ClassMap<Angazovanje>
    {
        public AngazovanjeMaps()
        {
            Table("ANGAZOVANJE");
            CompositeId()
                .KeyReference(x => x.ID_I, "ID_I")
                .KeyReference(x => x.ID_NII, "ID_NII");
            Map(x => x.DatumAngazovanja, "DATUM_ANGAZOVANJA").Not.Nullable();
            Map(x => x.DatumZavrsetka, "DATUM_ZAVRSETKA").Nullable();
            Map(x => x.OrganizacionaJedinica, "ORGANIZACIONA_JEDINICA").Not.Nullable();
            Map(x => x.NazivPozicije, "NAZIV_POZICIJE").Not.Nullable();
            Map(x => x.TipAngazovanja, "TIP_ANGAZOVANJA").Not.Nullable();
        }
    }
}
