using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    class AutorstvoMaps : ClassMap<Autorstvo>
    {
        public AutorstvoMaps()
        {
            Table("AUTORSTVO");
            CompositeId()
                .KeyReference(x => x.ID_U, "ID_U")
                .KeyReference(x => x.ID_P, "ID_P");
            Map(x => x.RedniBrojAutora, "REDNI_BROJ_AUTORA").Not.Nullable().Unique();
            Map(x => x.TipDoprinosa, "TIP_DOPRINOSA").Not.Nullable();
            Map(x => x.UlogaUPublikaciji, "ULOGA_U_PUBLIKACIJI").Not.Nullable();
        }
    }
}
