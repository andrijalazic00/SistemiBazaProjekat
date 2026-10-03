using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    class PripadajuciFajlMaps : ClassMap<PripadajuciFajl>
    {
        public PripadajuciFajlMaps()
        {
            Table("PRIPADAJUCI_FAJLOVI");
            CompositeId()
                .KeyReference(x => x.ID_IR, "ID_IR")
                .KeyProperty(x => x.BrojVerzije, "BROJ_VERZIJE")
                .KeyProperty(x => x.NazivFajla, "NAZIV_FAJLA");
        }
    }
}
