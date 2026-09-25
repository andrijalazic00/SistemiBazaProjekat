using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    class VerzijaMaps : ClassMap<Verzija>
    {
        public VerzijaMaps()
        {
            Table("VERZIJA");
            CompositeId()
                .KeyReference(x => x.ID_IR, "ID_IR")
                .KeyProperty(x => x.BrojVerzije, "BROJ_VERZIJE");
            Map(x => x.DatumPostavljanja, "DATUM_POSTAVLJANJA").Not.Nullable();
            Map(x => x.OpisIzmena, "OPIS_IZMENA").Not.Nullable();
            Map(x => x.OdgovornaOsoba, "ODGOVORNA_OSOBA").Not.Nullable();
        }
    }
}
