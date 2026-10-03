using datalibrary.Entiteti;
using FluentNHibernate.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace datalibrary.Mapiranja
{
    class UredujeMaps : ClassMap<Uredjuje>
    {
        public UredujeMaps()
        {
            Table("UREDJUJE");
            CompositeId()
                .KeyReference (x => x.ID_IR, "ID_IR")
                .KeyReference (x => x.ID_Urednika, "ID_UREDNIKA");
        }
    }
}
