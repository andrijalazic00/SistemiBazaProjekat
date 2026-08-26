
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using datalibrary.Entiteti;

namespace datalibrary.Mapiranja
{
    public class TelefonMaps : ClassMap<Telefon>
    {
        public TelefonMaps()
        {
            Table("TELEFON");
            CompositeId()
                .KeyReference(x => x.ID_I, "ID_I")
                .KeyProperty(x => x.Broj, "TELEFON");
        }
    }
}
